using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenDental.UI{ 
	public class ODGridCellList:List<OpenDental.UI.ODGridCell>{
		///<summary></summary>
		public void Add(string value) {
			this.Add(new ODGridCell(value));
		}
	}

	///<summary></summary>
	public class ODGridRow{		
		private ODGridCellList cells;
		private Color colorBackG;
		private bool bold;
		private Color colorText;
		private Color colorLborder;
		private object tag;
		private string note;
		private int height;
		
		///<summary>Creates a new ODGridRow.</summary>
		public ODGridRow(){
			cells=new ODGridCellList();
			colorBackG=Color.White;
			bold=false;
			colorText=Color.Black;
			colorLborder=Color.Empty;
			tag=null;
			note="";
			height=0;
		}

		///<summary></summary>
		public ODGridCellList	Cells{
			get{
				return cells;
			}
		}

	  ///<summary>Background color.</summary>
		public Color ColorBackG{
			get{
				return colorBackG;
			}
			set{
				colorBackG=value;
			}
		}

		///<summary></summary>
		public bool Bold{
			get{
				return bold;
			}
			set{
				bold=value;
			}
		} 
  
		///<summary>This sets the text color for the whole row.  Each gridCell also has a colorText property that will override this if set.</summary>
		public Color ColorText{
			get{
				return colorText;
			}
			set{
				colorText=value;
			}
		}

		///<summary></summary>
		public Color ColorLborder{
			get{
				return colorLborder;
			}
			set{
				colorLborder=value;
			}
		}

		///<summary>Used to store any kind of object that is associated with the row.</summary>
		public object Tag{
			get{
				return tag;
			}
			set{
				tag=value;
			}
		}

		///<summary>This is a very special field.  Since most of the tables in OD require the ability to attach long notes to each row, this field makes it possible.  Any note set here will be drawn as a sort of subrow.  The note can span multiple columns, as defined in grid.NoteSpanStart and grid.NoteSpanStop.</summary>
		public string Note{
			get {
				return note;
			}
			set {
				note=value;
			}
		}

		///<Summary>If not set (0), then the row height is computed automatically.</Summary>
		public int Height {
			get {
				return height;
			}
			set {
				height=value;
			}
		}
	        

	}

	









}






