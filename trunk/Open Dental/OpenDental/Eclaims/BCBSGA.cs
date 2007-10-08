using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;

namespace OpenDental.Eclaims
{
	/// <summary>
	/// Summary description for BCBSGA.
	/// </summary>
	public class BCBSGA{

		/// <summary></summary>
		public BCBSGA()
		{
			
		}

	

		///<summary>Returns true if the communications were successful, and false if they failed. If they failed, a rollback will happen automatically by deleting the previously created X12 file. The batchnum is supplied for the possible rollback.</summary>
		public static bool Launch(Clearinghouse clearhouse,int batchNum){
            return false;
		}

		///<summary>Retrieves any waiting reports from this clearinghouse. Returns true if the communications were successful, and false if they failed.</summary>
		public static bool Retrieve(Clearinghouse clearhouse){
            return false;
		}

		



	}
}

















