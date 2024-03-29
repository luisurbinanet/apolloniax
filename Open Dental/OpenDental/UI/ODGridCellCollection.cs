/*using System;
using System.Collections;

namespace OpenDental.UI{ 
	
	///<summary>A strongly typed collection of ODGridCells</summary>
	public class ODGridCellCollection:CollectionBase{

		///<summary>Returns the GridCell with the given index.</summary>
		public ODGridCell this[int index]{
      get{
				return (ODGridCell)List[index];
      }
      set{
				List[index]=value;
      }
		}

		///<summary></summary>
		public int Add(ODGridCell value){
			return(List.Add(value));
		}

		///<summary></summary>
		public int Add(string value){
			return(List.Add(new ODGridCell(value)));
		}

		///<summary></summary>
		public int IndexOf(ODGridCell value){
      return(List.IndexOf(value));
		}

		///<summary></summary>
		public void Insert(int index,ODGridCell value){
      List.Insert(index,value);
		}

		///<summary></summary>
		public void Remove(ODGridCell value){
      List.Remove(value);
		}

		///<summary></summary>
		public bool Contains(ODGridCell value){
      //If value is not of type ODGridCell, this will return false.
      return(List.Contains(value));
		}

		///<summary></summary>
		protected override void OnInsert(int index,Object value){
      if(value.GetType()!=typeof(ODGridCell))
				throw new ArgumentException("value must be of type ODGridCell.","value");
		}

		///<summary></summary>
		protected override void OnRemove( int index,Object value ){
      if(value.GetType()!=typeof(ODGridCell))
        throw new ArgumentException("value must be of type ODGridCell.","value");
		}

		///<summary></summary>
		protected override void OnSet(int index,Object oldValue,Object newValue){
      if(newValue.GetType()!=typeof(ODGridCell))
        throw new ArgumentException("newValue must be of type ODGridCell.","newValue");
		}

		///<summary></summary>
		protected override void OnValidate(Object value){
      if(value.GetType()!=typeof(ODGridCell))
        throw new ArgumentException("value must be of type ODGridCell.");
		}






	}
}

*/



















