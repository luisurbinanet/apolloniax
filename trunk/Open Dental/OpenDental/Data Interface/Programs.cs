using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using OpenDentBusiness;

namespace OpenDental{
	

	///<summary></summary>
	public class Programs{
		///<summary></summary>
		public static Hashtable HList;
		///<summary></summary>
		public static Program[] List;

		///<summary></summary>
		public static void Refresh(){
			//MessageBox.Show("refreshing");
			HList=new Hashtable();
			Program tempProgram = new Program();
			string command = 
				"SELECT * from program ORDER BY ProgDesc";
			DataTable table=General.GetTable(command);
			List=new Program[table.Rows.Count];
			for (int i=0;i<table.Rows.Count;i++){
				tempProgram=new Program();
				tempProgram.ProgramNum =PIn.PInt   (table.Rows[i][0].ToString());
				tempProgram.ProgName   =PIn.PString(table.Rows[i][1].ToString());
				tempProgram.ProgDesc   =PIn.PString(table.Rows[i][2].ToString());
				tempProgram.Enabled    =PIn.PBool  (table.Rows[i][3].ToString());
				tempProgram.Path       =PIn.PString(table.Rows[i][4].ToString());
				tempProgram.CommandLine=PIn.PString(table.Rows[i][5].ToString());
				tempProgram.Note       =PIn.PString(table.Rows[i][6].ToString());
				List[i]=tempProgram;
				if(!HList.ContainsKey(tempProgram.ProgName)){
					HList.Add(tempProgram.ProgName,tempProgram);
				}
			}
			//MessageBox.Show(HList.Count.ToString());
		}

		///<summary></summary>
		public static void Update(Program Cur){
			string command= "UPDATE program SET "
				+"ProgName = '"     +POut.PString(Cur.ProgName)+"'"
				+",ProgDesc  = '"   +POut.PString(Cur.ProgDesc)+"'"
				+",Enabled  = '"    +POut.PBool  (Cur.Enabled)+"'"
				+",Path = '"        +POut.PString(Cur.Path)+"'"
				+",CommandLine  = '"+POut.PString(Cur.CommandLine)+"'"
				+",Note  = '"       +POut.PString(Cur.Note)+"'"
				+" WHERE programnum = '"+POut.PInt(Cur.ProgramNum)+"'";
			General.NonQ(command);
		}

		///<summary></summary>
		public static void Insert(Program Cur){
			string command= "INSERT INTO program (ProgName,ProgDesc,Enabled,Path,CommandLine,Note"
				+") VALUES("
				+"'"+POut.PString(Cur.ProgName)+"', "
				+"'"+POut.PString(Cur.ProgDesc)+"', "
				+"'"+POut.PBool  (Cur.Enabled)+"', "
				+"'"+POut.PString(Cur.Path)+"', "
				+"'"+POut.PString(Cur.CommandLine)+"', "
				+"'"+POut.PString(Cur.Note)+"')";
			//MessageBox.Show(cmd.CommandText);
			Cur.ProgramNum=General.NonQ(command, true);
		}

		///<summary>This can only be called by the user if it is a program link that they created. Included program links cannot be deleted.  If calling this from ClassConversion, must delete any dependent ProgramProperties first.  It will delete ToolButItems for you.</summary>
		public static void Delete(Program Cur){
			ToolButItems.DeleteAllForProgram(Cur.ProgramNum);
			string command = "DELETE from program WHERE programnum = '"+Cur.ProgramNum.ToString()+"'";
			General.NonQ(command);
			
		}

		///<summary>Returns true if a Program link with the given name or number exists and is enabled.</summary>
		public static bool IsEnabled(string progName){
			if(HList.ContainsKey(progName) && ((Program)HList[progName]).Enabled){
				return true;
			}
			return false;
		}

		///<summary></summary>
		public static bool IsEnabled(int programNum){
			for(int i=0;i<List.Length;i++){
				if(List[i].ProgramNum==programNum && List[i].Enabled){
					return true;
				}
			}
			return false;
		}

		///<summary>Supply a valid program Name, and this will set Cur to be the corresponding Program object.</summary>
		public static Program GetCur(string progName){
			for(int i=0;i<List.Length;i++){
				if(List[i].ProgName==progName){
					return List[i];
				}
			}
			return null;//to signify that the program could not be located. (user deleted it in an older version)
		}

		///<summary>Typically used when user clicks a button to a Program link.  This method attempts to identify and execute the program based on the given programNum.</summary>
		public static void Execute(int programNum,Patient pat){
		}
	}
}










