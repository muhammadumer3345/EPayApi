
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/19/2015 3:47:53 PM
// Last Updated on: 

using System;
namespace EPay.DataClasses
{
    public partial class USERDC : AbstractDataClass
	{	
 		public int USER_ID { get; set; }
 		public string USER_NAME { get; set; }
 		public string PASSWORD { get; set; }
 		public string FIRST_NAME { get; set; }
 		public string LAST_NAME { get; set; }
 		public string EMAIL_ADDRESS { get; set; }
 		public string OFFICE_PHONE { get; set; }
 		public string MOBILE_PHONE { get; set; }
 		public string SECURITY_QUESTION { get; set; }
 		public string ANSWER { get; set; }
 		public string STATUS { get; set; }
 		public DateTime CREATED_ON { get; set; }
 		public int CREATED_BY { get; set; }
 		public DateTime MODIFIED_ON { get; set; }
 		public int MODIFIED_BY { get; set; }
 		public bool IsDirty { get; set; }
        public int LOCK_COUNTER { get; set; }
	}
}