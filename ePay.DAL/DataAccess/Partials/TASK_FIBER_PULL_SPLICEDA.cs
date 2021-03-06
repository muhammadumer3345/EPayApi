
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 1/23/2017 5:02:46 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using EPay.DataClasses;
using EPay.Common;

namespace EPay.DataAccess
{		
	public class TASK_FIBER_PULL_SPLICEDA : HYLAN_TASKDA
    {
		public bool IsDirty {get; set;}

        //=================================================================
        //  	public Function LoadAll() As Boolean
        //=================================================================
        //  Loads all of the records in the database, and sets the currentRow to the first row
        //=================================================================
        public override List<HYLAN_TASKDC> LoadAll(DBConnection Connection, int TASK_TITLE_ID)
		{
			List<HYLAN_TASKDC> objTASK_FIBER_PULL_SPLICE = new List<HYLAN_TASKDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_FIBER_PULL_SPLICELoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_FIBER_PULL_SPLICE.AddRange(Utility.ConvertToObjects<TASK_FIBER_PULL_SPLICEDC>(ds.Tables[0]));
            return objTASK_FIBER_PULL_SPLICE;
        }

        public override HYLAN_TASKDC LoadByPrimaryKey(DBConnection Connection, int TASK_TITLE_ID, int JOB_ID)
		{
			TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE = new TASK_FIBER_PULL_SPLICEDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_FIBER_PULL_SPLICELoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, JOB_ID);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_FIBER_PULL_SPLICE = (Utility.ConvertToObject<TASK_FIBER_PULL_SPLICEDC>(ds.Tables[0]));
            if (ds.Tables.Count > 1)
            {
                HYLAN_TASKDC hylanTaskDC = (Utility.ConvertToObject<HYLAN_TASKDC>(ds.Tables[1]));
                objTASK_FIBER_PULL_SPLICE.TASK_TITLE_ID = hylanTaskDC.TASK_TITLE_ID;
                objTASK_FIBER_PULL_SPLICE.TASK_NAME = hylanTaskDC.TASK_NAME;
            }
            return objTASK_FIBER_PULL_SPLICE;
        }
        public override int Update(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FIBER_PULL_SPLICEs)        
        {
            int updatedCount = 0;
            foreach (TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE in objTASK_FIBER_PULL_SPLICEs)
            {
                updatedCount = Update(Connection, objTASK_FIBER_PULL_SPLICE);
            }
            return updatedCount;
        }
        private int Update(DBConnection Connection, TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FIBER_PULL_SPLICEUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_FIBER_PULL_SPLICE.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_FIBER_PULL_SPLICE.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_FIBER_PULL_SPLICE.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_FIBER_PULL_SPLICE.NOTES);
			dbCommandWrapper.AddInParameter("p_FIBER_TYPE", DbType.Int32, objTASK_FIBER_PULL_SPLICE.FIBER_TYPE);
			dbCommandWrapper.AddInParameter("p_FIBER_OPTIC_POSITION", DbType.Int32, objTASK_FIBER_PULL_SPLICE.FIBER_OPTIC_POSITION);
			dbCommandWrapper.AddInParameter("p_LIGHT_TEST_CLIENT_DATE", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.LIGHT_TEST_CLIENT_DATE);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_FIBER_PULL_SPLICE.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_FIBER_PULL_SPLICE.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_FIBER_PULL_SPLICE.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objTASK_FIBER_PULL_SPLICE.IsDirty = IsDirty = true;
            
			return updateCount;
        }
        public override int Insert(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FIBER_PULL_SPLICEs)        
        {
            int insertCount = 0;
            foreach (TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE in objTASK_FIBER_PULL_SPLICEs)
            {
                 insertCount = Insert(Connection, objTASK_FIBER_PULL_SPLICE);
            }
            return  insertCount;
        }
		private int Insert(DBConnection Connection, TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FIBER_PULL_SPLICEInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_FIBER_PULL_SPLICE.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_FIBER_PULL_SPLICE.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_FIBER_PULL_SPLICE.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_FIBER_PULL_SPLICE.NOTES);
			dbCommandWrapper.AddInParameter("p_FIBER_TYPE", DbType.Int32, objTASK_FIBER_PULL_SPLICE.FIBER_TYPE);
			dbCommandWrapper.AddInParameter("p_FIBER_OPTIC_POSITION", DbType.Int32, objTASK_FIBER_PULL_SPLICE.FIBER_OPTIC_POSITION);
			dbCommandWrapper.AddInParameter("p_LIGHT_TEST_CLIENT_DATE", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.LIGHT_TEST_CLIENT_DATE);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_FIBER_PULL_SPLICE.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_FIBER_PULL_SPLICE.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_FIBER_PULL_SPLICE.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_FIBER_PULL_SPLICE.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public override int Delete(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FIBER_PULL_SPLICEs)        
        {
            int deleteCount = 0;
            foreach (TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE in objTASK_FIBER_PULL_SPLICEs)
            {
                 deleteCount = Delete(Connection, objTASK_FIBER_PULL_SPLICE);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, TASK_FIBER_PULL_SPLICEDC objTASK_FIBER_PULL_SPLICE)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FIBER_PULL_SPLICEDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FIBER_PULL_SPLICE.TASK_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
		
	}
}
