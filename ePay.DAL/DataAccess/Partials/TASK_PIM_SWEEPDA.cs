
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
	public class TASK_PIM_SWEEPDA : HYLAN_TASKDA
    {
		public bool IsDirty {get; set;}

        //=================================================================
        //  	public Function LoadAll() As Boolean
        //=================================================================
        //  Loads all of the records in the database, and sets the currentRow to the first row
        //=================================================================
        public override List<HYLAN_TASKDC> LoadAll(DBConnection Connection, int TASK_TITLE_ID)
		{
			List<HYLAN_TASKDC> objTASK_PIM_SWEEP = new List<HYLAN_TASKDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_PIM_SWEEPLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_PIM_SWEEP.AddRange(Utility.ConvertToObjects<TASK_PIM_SWEEPDC>(ds.Tables[0]));
            return objTASK_PIM_SWEEP;
        }

        public override HYLAN_TASKDC LoadByPrimaryKey(DBConnection Connection, int TASK_TITLE_ID, int JOB_ID)
		{
			TASK_PIM_SWEEPDC objTASK_PIM_SWEEP = new TASK_PIM_SWEEPDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_PIM_SWEEPLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, JOB_ID);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_PIM_SWEEP = (Utility.ConvertToObject<TASK_PIM_SWEEPDC>(ds.Tables[0]));
            if (ds.Tables.Count > 1)
            {
                HYLAN_TASKDC hylanTaskDC = (Utility.ConvertToObject<HYLAN_TASKDC>(ds.Tables[1]));
                objTASK_PIM_SWEEP.TASK_TITLE_ID = hylanTaskDC.TASK_TITLE_ID;
                objTASK_PIM_SWEEP.TASK_NAME = hylanTaskDC.TASK_NAME;
            }
            return objTASK_PIM_SWEEP;
        }
        public override int Update(DBConnection Connection, List<HYLAN_TASKDC> objTASK_PIM_SWEEPs)        
        {
            int updatedCount = 0;
            foreach (TASK_PIM_SWEEPDC objTASK_PIM_SWEEP in objTASK_PIM_SWEEPs)
            {
                updatedCount = Update(Connection, objTASK_PIM_SWEEP);
            }
            return updatedCount;
        }
		private int Update(DBConnection Connection, TASK_PIM_SWEEPDC objTASK_PIM_SWEEP)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_PIM_SWEEPUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_PIM_SWEEP.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_PIM_SWEEP.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_PIM_SWEEP.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_PIM_SWEEP.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_PIM_SWEEP.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_SUBMITTED_DATE", DbType.DateTime, objTASK_PIM_SWEEP.SUBMITTED_DATE);
			dbCommandWrapper.AddInParameter("p_CLIENT_APPROVAL_DATE", DbType.DateTime, objTASK_PIM_SWEEP.CLIENT_APPROVAL_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_PIM_SWEEP.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_PIM_SWEEP.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_PIM_SWEEP.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_PIM_SWEEP.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_PIM_SWEEP.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_PIM_SWEEP.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_PIM_SWEEP.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_PIM_SWEEP.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objTASK_PIM_SWEEP.IsDirty = IsDirty = true;
            
			return updateCount;
        }
        public override int Insert(DBConnection Connection, List<HYLAN_TASKDC> objTASK_PIM_SWEEPs)        
        {
            int insertCount = 0;
            foreach (TASK_PIM_SWEEPDC objTASK_PIM_SWEEP in objTASK_PIM_SWEEPs)
            {
                 insertCount = Insert(Connection, objTASK_PIM_SWEEP);
            }
            return  insertCount;
        }
		private int Insert(DBConnection Connection, TASK_PIM_SWEEPDC objTASK_PIM_SWEEP)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_PIM_SWEEPInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_PIM_SWEEP.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_PIM_SWEEP.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_PIM_SWEEP.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_PIM_SWEEP.REQUIRED);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_PIM_SWEEP.ACT_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_SUBMITTED_DATE", DbType.DateTime, objTASK_PIM_SWEEP.SUBMITTED_DATE);
			dbCommandWrapper.AddInParameter("p_CLIENT_APPROVAL_DATE", DbType.DateTime, objTASK_PIM_SWEEP.CLIENT_APPROVAL_DATE);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_REASON", DbType.Int32, objTASK_PIM_SWEEP.ON_HOLD_REASON);
			dbCommandWrapper.AddInParameter("p_ON_HOLD_OTHER", DbType.String, objTASK_PIM_SWEEP.ON_HOLD_OTHER);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_PIM_SWEEP.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_PIM_SWEEP.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_PIM_SWEEP.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_PIM_SWEEP.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_PIM_SWEEP.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_PIM_SWEEP.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public override int Delete(DBConnection Connection, List<HYLAN_TASKDC> objTASK_PIM_SWEEPs)        
        {
            int deleteCount = 0;
            foreach (TASK_PIM_SWEEPDC objTASK_PIM_SWEEP in objTASK_PIM_SWEEPs)
            {
                 deleteCount = Delete(Connection, objTASK_PIM_SWEEP);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, TASK_PIM_SWEEPDC objTASK_PIM_SWEEP)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_PIM_SWEEPDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_PIM_SWEEP.TASK_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
	
	}
}
