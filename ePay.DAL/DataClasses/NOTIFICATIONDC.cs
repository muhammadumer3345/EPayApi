
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 5/13/2015 3:40:53 PM
// Last Updated on: 

using System;
namespace EPay.DataClasses
{
    public class NOTIFICATIONDC : AbstractDataClass
	{
        public int NOTIFICATION_ID { get; set; }
        public int? EVENT_ID { get; set; }
        public int? EVENT_TYPE { get; set; }
 		public DateTime CREATED_DATE { get; set; }
 		public int TYPE { get; set; }
        public string TYPE_NAME { get; set; }
        public string TIME_ZONE { get; set; }
 		public string NOTIFICATION { get; set; }
        public int NO_OF_NOTIFICATIONS { get; set; }
        public int CREATED_BY { get; set; }
 		public bool IsDirty { get; set; }
        public Boolean DST_APPLIED_CREATED_DATE { get; set; }
        public string CREATED_DATE_STRING { get; set; }
       
	}
}
