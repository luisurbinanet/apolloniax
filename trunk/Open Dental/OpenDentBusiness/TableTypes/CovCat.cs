using System;
using System.Collections;

namespace OpenDentBusiness{

	///<summary>Insurance coverage categories.  They need to look like in the manual for the American calculations to work properly.</summary>
	public class CovCat {
		///<summary>Primary key.</summary>
		public int CovCatNum;
		///<summary>Description of this category.</summary>
		public string Description;
		///<summary>Default percent for this category. -1 to skip this category and not apply a percentage.</summary>
		public int DefaultPercent;
		///<summary>The order in which the categories are displayed.  Includes hidden categories. 0-based.</summary>
		public int CovOrder;
		///<summary>If true, this category will be hidden.</summary>
		public bool IsHidden;
		///<summary>Enum:EbenefitCategory  The X12 benefit categories.  Each CovCat can link to one X12 category.  Default is 0 (unlinked).</summary>
		public EbenefitCategory EbenefitCat;

		///<summary></summary>
		public CovCat Copy() {
			CovCat c=new CovCat();
			c.CovCatNum=CovCatNum;
			c.Description=Description;
			c.DefaultPercent=DefaultPercent;
			c.CovOrder=CovOrder;
			c.IsHidden=IsHidden;
			c.EbenefitCat=EbenefitCat;
			return c;
		}


	}

	public class DtoCovCatRefresh:DtoQueryBase {
	}
	



}









