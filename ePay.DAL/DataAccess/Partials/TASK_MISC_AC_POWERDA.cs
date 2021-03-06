
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
	public class TASK_MISC_AC_POWERDA : HYLAN_TASKDA
    {
		public bool IsDirty {get; set;}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public override List<HYLAN_TASKDC> LoadAll(DBConnection Connection, int TASK_TITLE_ID)
		{
			List<HYLAN_TASKDC> objTASK_MISC_AC_POWER = new List<HYLAN_TASKDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_MISC_AC_POWERLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_MISC_AC_POWER.AddRange(Utility.ConvertToObjects<TASK_MISC_AC_POWERDC>(ds.Tables[0]));
            return objTASK_MISC_AC_POWER;
        }

        public override HYLAN_TASKDC LoadByPrimaryKey(DBConnection Connection, int TASK_TITLE_ID, int JOB_ID)
		{
			TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER = new TASK_MISC_AC_POWERDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_MISC_AC_POWERLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, JOB_ID);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_MISC_AC_POWER = (Utility.ConvertToObject<TASK_MISC_AC_POWERDC>(ds.Tables[0]));
            if (ds.Tables.Count > 1)
            {
                HYLAN_TASKDC hylanTaskDC = (Utility.ConvertToObject<HYLAN_TASKDC>(ds.Tables[1]));
                objTASK_MISC_AC_POWER.TASK_TITLE_ID = hylanTaskDC.TASK_TITLE_ID;
                objTASK_MISC_AC_POWER.TASK_NAME = hylanTaskDC.TASK_NAME;
            }
            return objTASK_MISC_AC_POWER;
        }
        public override int Update(DBConnection Connection, List<HYLAN_TASKDC> objTASK_MISC_AC_POWERs)        
        {
            int updatedCount = 0;
            foreach (TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER in objTASK_MISC_AC_POWERs)
            {
                updatedCount = Update(Connection, objTASK_MISC_AC_POWER);
            }
            return updatedCount;
        }
		private int Update(DBConnection Connection, TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_MISC_AC_POWERUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_MISC_AC_POWER.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_MISC_AC_POWER.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_MISC_AC_POWER.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_MISC_AC_POWER.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_MISC_AC_POWER.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_MISC_AC_POWER.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_MISC_AC_POWER.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_MISC_AC_POWER.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_MISC_AC_POWER.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_MISC_AC_POWER.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_MISC_AC_POWER.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_MISC_AC_POWER.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_MISC_AC_POWER.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objTASK_MISC_AC_POWER.IsDirty = IsDirty = true;
            
			return updateCount;
        }
        public override int Insert(DBConnection Connection, List<HYLAN_TASKDC> objTASK_MISC_AC_POWERs)        
        {
            int insertCount = 0;
            foreach (TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER in objTASK_MISC_AC_POWERs)
            {
                 insertCount = Insert(Connection, objTASK_MISC_AC_POWER);
            }
            return  insertCount;
        }
		private int Insert(DBConnection Connection, TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_MISC_AC_POWERInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_MISC_AC_POWER.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_MISC_AC_POWER.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_MISC_AC_POWER.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_MISC_AC_POWER.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_MISC_AC_POWER.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_MISC_AC_POWER.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_MISC_AC_POWER.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_MISC_AC_POWER.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_MISC_AC_POWER.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_MISC_AC_POWER.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_MISC_AC_POWER.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_MISC_AC_POWER.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_MISC_AC_POWER.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public override int Delete(DBConnection Connection, List<HYLAN_TASKDC> objTASK_MISC_AC_POWERs)        
        {
            int deleteCount = 0;
            foreach (TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER in objTASK_MISC_AC_POWERs)
            {
                 deleteCount = Delete(Connection, objTASK_MISC_AC_POWER);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, TASK_MISC_AC_POWERDC objTASK_MISC_AC_POWER)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_MISC_AC_POWERDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_MISC_AC_POWER.TASK_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
		
	}
}
