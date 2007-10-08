using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

namespace OpenDentBusiness {
	public class GeneralB {
		///<summary></summary>
		public static DataSet GetTable(string command) {
			DataConnection dcon=new DataConnection();
			DataTable table=dcon.GetTable(command);
			DataSet retVal=new DataSet();
			//table.TableName="table";
			retVal.Tables.Add(table);
			//retVal.Tables[0].TableName="";
			return retVal;
		}

		///<summary>Only used if using the server component.  This is used for queries written by the user.  It uses the user with lower privileges  to prevent injection attack.</summary>
		public static DataSet GetTableLow(string command) {
			DataConnection dcon=new DataConnection(true);
			DataTable table=dcon.GetTable(command);
			DataSet retVal=new DataSet();
			retVal.Tables.Add(table);
			return retVal;
		}

		///<summary>This query is run with full privileges.  This is for commands generated by the main program, and the user will not have access for injection attacks.  Result is usually number of rows changed, or can be insert id if requested.</summary>
		public static int NonQ(string command,bool getInsertID) {
			DataConnection dcon=new DataConnection();
			int rowsChanged=dcon.NonQ(command,getInsertID);
			if(getInsertID){
				return dcon.InsertID;
			}
			else{
				return rowsChanged;
			}
		}

		public static int NonQ(string command){
			return NonQ(command,false);
		}

		/*
		///<summary>This query is run with full privileges.</summary>
		public static int NonQ(string[] commands) {
			DataConnection dcon=new DataConnection();
			
			int rowsChanged=dcon.NonQ(cmd);
			return rowsChanged;//I don't think this will be accurate
		}*/

		///<summary>This is for multiple queries all concatenated together with ;</summary>
		public static DataSet GetDataSet(string commands){
			DataConnection dcon=new DataConnection();
			//DataTable table=dcon.GetTable(command);
			DataSet retVal=dcon.GetDs(commands);
			//retVal.Tables.Add(table);
			return retVal;
		}

		public static DataSet GetDS(string methodName, string[] parameters) {
			switch (methodName){
				default:
					throw new ApplicationException("MethodName not found");
				case "Appointment.GetApptEdit":
					return AppointmentB.GetApptEdit(parameters);
				case "Appointment.RefreshPeriod":
					return AppointmentB.RefreshPeriod(parameters);
				case "Appointment.RefreshOneApt":
					return AppointmentB.RefreshOneApt(parameters);
					
			}

		}
		


	}
}