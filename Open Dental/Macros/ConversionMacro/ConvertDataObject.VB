Imports System
Imports EnvDTE
Imports EnvDTE80
Imports System.Diagnostics
Imports System.Windows.Forms

Public Module ConvertDataObject
    Public Sub Convert()
        Dim projectItem As ProjectItem = DTE.ActiveDocument.ProjectItem
        Dim fileCodeModel As FileCodeModel = projectItem.FileCodeModel
        Dim namespaceElement As CodeElement
        Dim classElement As CodeElement

        Dim element As CodeElement
        For Each element In fileCodeModel.CodeElements
            ' Enter the namespace
            If element.Kind = vsCMElement.vsCMElementNamespace Then
                namespaceElement = element
                Exit For
            End If
        Next

        For Each element In namespaceElement.Children
            If element.Kind = vsCMElement.vsCMElementClass Then
                classElement = element
                Exit For
            End If
        Next

        ' get the variable's parent
        Dim codeClass As CodeClass = CType(classElement, CodeClass)

        ' Make the class inherit from "DataObjectBase"
        codeClass.AddBase("DataObjectBase")
        codeClass.AddAttribute("DataObject", """" + codeClass.Name.ToLower() + """")

        For Each element In classElement.Children
            If element.Kind = vsCMElement.vsCMElementVariable Then
                ' we've tested so we know its a variable
                Dim codeVariable As CodeVariable = CType(element, CodeVariable)
                Dim fieldName As String = codeVariable.Name
                Dim propertyName As String = fieldName
                Dim fieldType As String = codeVariable.Type.AsString

                If Not Char.IsUpper(fieldName(0)) Then
                    MessageBox.Show(String.Format("The field {0} does not start with an upper case letter. Can not continue refactoring!", fieldName))
                    Continue For
                End If

                fieldName = String.Concat(Char.ToLower(fieldName(0)), fieldName.Substring(1))

                ' add the DataField attribute
                codeVariable.AddAttribute("DataField", """" + propertyName + """")

                ' rename the field so we don't have a collision with property
                codeVariable.Name = fieldName

                ' make sure field is private
                codeVariable.Access = vsCMAccess.vsCMAccessPrivate

                ' add a new property
                Dim codeProperty As CodeProperty = codeClass.AddProperty("dummy", _
                    "dummy", fieldType, element)

                codeProperty.Name = propertyName

                ' implement the getter
                Dim getExpression As String = "get { return " + fieldName + "; }"
                Dim getter As EditPoint = codeProperty.Getter.StartPoint.CreateEditPoint()
                getter.ReplaceText(codeProperty.Getter.EndPoint, getExpression, vsEPReplaceTextOptions.vsEPReplaceTextAutoformat)

                ' implement the setter
                Dim setExpression As String = "set { " + fieldName + "= value;MarkDirty();}"
                Dim setter As EditPoint = codeProperty.Setter.StartPoint.CreateEditPoint()
                setter.ReplaceText(codeProperty.Setter.EndPoint, setExpression, vsEPReplaceTextOptions.vsEPReplaceTextAutoformat)

                ' move the Doc comments
                codeProperty.DocComment = codeVariable.DocComment
            End If
        Next
    End Sub

    Public Sub AutoConvert2()
        Dim document As Document
        For Each document In DTE.Documents
            document.Activate()
            Convert2(document)
            document.Save()
            document.Close()
        Next
    End Sub
    Public Sub Convert2()
        Convert2(DTE.ActiveDocument)
    End Sub

    Public Sub Convert2(ByVal document As Document)
        Dim projectItem As ProjectItem = document.ProjectItem
        Dim fileCodeModel As FileCodeModel = ProjectItem.FileCodeModel
        Dim namespaceElement As CodeElement
        Dim classElement As CodeElement

        Dim element As CodeElement
        For Each element In fileCodeModel.CodeElements
            ' Enter the namespace
            If element.Kind = vsCMElement.vsCMElementNamespace Then
                namespaceElement = element
                Exit For
            End If
        Next

        For Each element In namespaceElement.Children
            If element.Kind = vsCMElement.vsCMElementClass Then
                classElement = element
                Exit For
            End If
        Next

        ' get the variable's parent
        Dim codeClass As CodeClass = CType(classElement, CodeClass)

        For Each element In classElement.Children
            If element.Kind = vsCMElement.vsCMElementProperty Then
                Dim codeProperty As CodeProperty = CType(element, CodeProperty)
                Dim fieldName As String = CodeProperty.Name
                Dim propertyName As String = fieldName
                Dim fieldType As String = CodeProperty.Type.AsString

                If Not Char.IsUpper(fieldName(0)) Then
                    MessageBox.Show(String.Format("The property {0} does not start with an upper case letter. Can not continue refactoring!", fieldName))
                    Continue For
                End If

                fieldName = String.Concat(Char.ToLower(fieldName(0)), fieldName.Substring(1))

                ' Mark the item as public
                codeProperty.Access = vsCMAccess.vsCMAccessPublic

                ' Update the setter
                Dim setExpression As String = "set { " + fieldName + "= value;MarkDirty(); " + fieldName + "Changed = true; }"
                Dim setter As EditPoint = CodeProperty.Setter.StartPoint.CreateEditPoint()
                setter.ReplaceText(codeProperty.Setter.EndPoint, setExpression, vsEPReplaceTextOptions.vsEPReplaceTextAutoformat)

                ' Add an extra propertyChanged field
                Dim changedVariable As CodeVariable = CodeClass.AddVariable(fieldName + "Changed", GetType(System.Boolean).ToString(), element)

                ' Add a PropertyChanged property
                Dim changedProperty As CodeProperty = CodeClass.AddProperty("dummy", _
                    "dummy", GetType(System.Boolean).ToString(), changedVariable)

                changedProperty.Name = propertyName + "Changed"
                changedProperty.Access = vsCMAccess.vsCMAccessPublic

                ' implement the getter
                Dim getExpression As String = "get { return " + fieldName + "Changed; }"
                Dim getter As EditPoint = changedProperty.Getter.StartPoint.CreateEditPoint()
                getter.ReplaceText(changedProperty.Getter.EndPoint, getExpression, vsEPReplaceTextOptions.vsEPReplaceTextAutoformat)

                ' implement the setter
                setExpression = String.Empty
                setter = changedProperty.Setter.StartPoint.CreateEditPoint()
                setter.Delete(changedProperty.Setter.EndPoint)
            End If
        Next
    End Sub
    Public Sub FixWhiteSpace()
        'Looks like I'm going to have to learn how to do this Macro thing before this can be implemented.
        'The plan is to make the file more human readable.  See Mount.cs.  I only had time to do the first three fields.
        'I have a very specific way that I want the whitespace to show, but it will take time to create a macro
        'which can do it. -Jordan
    End Sub
End Module


