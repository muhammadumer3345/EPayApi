
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/19/2015 3:47:53 PM
// Last Updated on: 

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;

namespace EPay.DataClasses
{

    public partial class COMPANIEDC : AbstractDataClass
	{	
 		public int COMPANY_ID { get; set; }
 		public string COMPANY_NAME { get; set; }
 		//public long TOTAL_CUSTOMERS { get; set; }
 		//public int HOME_RMAG { get; set; }
   //     public RMAGDC RMAG = new RMAGDC();
       
 		public string COMPANY_PHONE_NUMBER { get; set; }
 		public string PRIMARY_CONTACT_NAME { get; set; }
 		public string PRIMARY_CONTACT_EMAIL { get; set; }
 		public string STATUS { get; set; }
 		public DateTime CREATED_ON { get; set; }
 		public int CREATED_BY { get; set; }
 		public DateTime MODIFIED_ON { get; set; }
 		public int MODIFIED_BY { get; set; }
 		public bool IsDirty { get; set; }
        
       
	}
}
