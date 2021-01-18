
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
	public class TASK_FOUNDATION_POLE_WORKDA : HYLAN_TASKDA
    {
		public bool IsDirty {get; set;}

        //=================================================================
        //  	public Function LoadAll() As Boolean
        //=================================================================
        //  Loads all of the records in the database, and sets the currentRow to the first row
        //=================================================================
        public override List<HYLAN_TASKDC> LoadAll(DBConnection Connection, int TASK_TITLE_ID)
		{
			List<HYLAN_TASKDC> objTASK_FOUNDATION_POLE_WORK = new List<HYLAN_TASKDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_FOUNDATION_POLE_WORKLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_FOUNDATION_POLE_WORK.AddRange(Utility.ConvertToObjects<TASK_FOUNDATION_POLE_WORKDC>(ds.Tables[0]));
            return objTASK_FOUNDATION_POLE_WORK;
        }

        public override HYLAN_TASKDC LoadByPrimaryKey(DBConnection Connection, int TASK_TITLE_ID, int JOB_ID)
		{
			TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK = new TASK_FOUNDATION_POLE_WORKDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_FOUNDATION_POLE_WORKLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, JOB_ID);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_FOUNDATION_POLE_WORK = (Utility.ConvertToObject<TASK_FOUNDATION_POLE_WORKDC>(ds.Tables[0]));
            if (ds.Tables.Count > 1)
            {
                HYLAN_TASKDC hylanTaskDC = (Utility.ConvertToObject<HYLAN_TASKDC>(ds.Tables[1]));
                objTASK_FOUNDATION_POLE_WORK.TASK_TITLE_ID = hylanTaskDC.TASK_TITLE_ID;
                objTASK_FOUNDATION_POLE_WORK.TASK_NAME = hylanTaskDC.TASK_NAME;
            }
            return objTASK_FOUNDATION_POLE_WORK;
        }
        public override int Update(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FOUNDATION_POLE_WORKs)        
        {
            int updatedCount = 0;
            foreach (TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK in objTASK_FOUNDATION_POLE_WORKs)
            {
                updatedCount = Update(Connection, objTASK_FOUNDATION_POLE_WORK);
            }
            return updatedCount;
        }
		private int Update(DBConnection Connection, TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FOUNDATION_POLE_WORKUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_FOUNDATION_POLE_WORK.REQUIRED);
			dbCommandWrapper.AddInParameter("p_EST_START_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.EST_START_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_START_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.ACT_START_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_FOUNDATION_POLE_WORK.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_FOUNDATION_POLE_WORK.NOTES);
			dbCommandWrapper.AddInParameter("p_FOUNDATION_WORK_TYPE", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.FOUNDATION_WORK_TYPE);
			dbCommandWrapper.AddInParameter("p_POLE_WORK_TYPE", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.POLE_WORK_TYPE);
			dbCommandWrapper.AddInParameter("p_CONED_TICKET_NUMBER", DbType.String, objTASK_FOUNDATION_POLE_WORK.CONED_TICKET_NUMBER);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objTASK_FOUNDATION_POLE_WORK.IsDirty = IsDirty = true;
            
			return updateCount;
        }
        public override int Insert(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FOUNDATION_POLE_WORKs)        
        {
            int insertCount = 0;
            foreach (TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK in objTASK_FOUNDATION_POLE_WORKs)
            {
                 insertCount = Insert(Connection, objTASK_FOUNDATION_POLE_WORK);
            }
            return  insertCount;
        }
		private int Insert(DBConnection Connection, TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FOUNDATION_POLE_WORKInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_FOUNDATION_POLE_WORK.REQUIRED);
			dbCommandWrapper.AddInParameter("p_EST_START_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.EST_START_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_START_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.ACT_START_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_FOUNDATION_POLE_WORK.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_FOUNDATION_POLE_WORK.NOTES);
			dbCommandWrapper.AddInParameter("p_FOUNDATION_WORK_TYPE", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.FOUNDATION_WORK_TYPE);
			dbCommandWrapper.AddInParameter("p_POLE_WORK_TYPE", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.POLE_WORK_TYPE);
			dbCommandWrapper.AddInParameter("p_CONED_TICKET_NUMBER", DbType.String, objTASK_FOUNDATION_POLE_WORK.CONED_TICKET_NUMBER);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_FOUNDATION_POLE_WORK.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public override int Delete(DBConnection Connection, List<HYLAN_TASKDC> objTASK_FOUNDATION_POLE_WORKs)        
        {
            int deleteCount = 0;
            foreach (TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK in objTASK_FOUNDATION_POLE_WORKs)
            {
                 deleteCount = Delete(Connection, objTASK_FOUNDATION_POLE_WORK);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, TASK_FOUNDATION_POLE_WORKDC objTASK_FOUNDATION_POLE_WORK)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_FOUNDATION_POLE_WORKDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_FOUNDATION_POLE_WORK.TASK_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
	
	}
}
