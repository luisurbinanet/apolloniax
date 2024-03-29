using System;
using System.Collections;

namespace OpenDental.UI{ 
	
	///<summary>A strongly typed collection of ODGridColumns</summary>
	public class ODGridColumnCollection:CollectionBase{

		///<summary>Returns the GridColumn with the given index.</summary>
		public ODGridColumn this[int index]{
      get{
				return (ODGridColumn)List[index];
      }
      set{
				List[index]=value;
      }
		}

		/*public ODGridColumn Item(int index){
			return (ODGridColumn)List[index];
		}*/

		///<summary></summary>
		public int Add(ODGridColumn value){
			return(List.Add(value));
		}

		///<summary></summary>
		public int IndexOf(ODGridColumn value){
      return(List.IndexOf(value));
		}

		///<summary></summary>
		public void Insert(int index,ODGridColumn value){
      List.Insert(index,value);
		}

		///<summary></summary>
		public void Remove(ODGridColumn value){
      List.Remove(value);
		}

		///<summary></summary>
		public bool Contains(ODGridColumn value){
      // If value is not of type ODGridColumn, this will return false.
      return(List.Contains(value));
		}

		///<summary></summary>
		protected override void OnInsert(int index,Object value){
      if(value.GetType()!=typeof(ODGridColumn))
				throw new ArgumentException("value must be of type ODGridColumn.","value");
		}

		///<summary></summary>
		protected override void OnRemove( int index,Object value ){
      if(value.GetType()!=typeof(ODGridColumn))
        throw new ArgumentException("value must be of type ODGridColumn.","value");
		}

		///<summary></summary>
		protected override void OnSet(int index,Object oldValue,Object newValue){
      if(newValue.GetType()!=typeof(ODGridColumn))
        throw new ArgumentException("newValue must be of type ODGridColumn.","newValue");
		}

		///<summary></summary>
		protected override void OnValidate(Object value){
      if(value.GetType()!=typeof(ODGridColumn))
        throw new ArgumentException("value must be of type ODGridColumn.");
		}

		///<summary>Gets the index of the column with the specified heading.</summary>
		public int GetIndex(string heading){
			for(int i=0;i<List.Count;i++){
				if(((ODGridColumn)List[i]).Heading==heading){
					return i;
				}
			}
			return -1;//not found
		}







/*
		///<summary></summary>
		public void Remove(int index){
			if((index>Count-1) || (index<0)){
				throw new System.IndexOutOfRangeException();
			}
			else{
				List.RemoveAt(index);
			}
		}*/

		/*
		///<summary>The button is retrieved from List and explicitly cast to the button type.</summary>
		public ODToolBarButton Item(int index){
			return (ODToolBarButton)List[index];
		}*/

		/*
		///<summary></summary>
		public int IndexOf(ODGridColumn value){
			return(List.IndexOf(value));
		}*/

	}
}





















