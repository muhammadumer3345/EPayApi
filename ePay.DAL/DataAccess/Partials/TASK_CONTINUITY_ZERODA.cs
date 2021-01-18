
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 1/23/2017 5:02:45 PM
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
	public class TASK_CONTINUITY_ZERODA : HYLAN_TASKDA
    {
		public bool IsDirty {get; set;}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public override List<HYLAN_TASKDC> LoadAll(DBConnection Connection, int TASK_TITLE_ID)
		{
			List<HYLAN_TASKDC> objTASK_CONTINUITY_ZERO = new List<HYLAN_TASKDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_CONTINUITY_ZEROLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);

            DataSet ds = new DataSet();
			
			if (Connection.Transaction != null)
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_CONTINUITY_ZERO.AddRange(Utility.ConvertToObjects<TASK_CONTINUITY_ZERODC>(ds.Tables[0]));
            return objTASK_CONTINUITY_ZERO;
		}

        public override HYLAN_TASKDC LoadByPrimaryKey(DBConnection Connection, int TASK_TITLE_ID, int JOB_ID)
		{
			TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO = new TASK_CONTINUITY_ZERODC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_TASK_CONTINUITY_ZEROLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, JOB_ID);
            dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, TASK_TITLE_ID);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objTASK_CONTINUITY_ZERO = (Utility.ConvertToObject<TASK_CONTINUITY_ZERODC>(ds.Tables[0]));
            if (ds.Tables.Count > 1)
            {
                HYLAN_TASKDC hylanTaskDC = (Utility.ConvertToObject<HYLAN_TASKDC>(ds.Tables[1]));
                objTASK_CONTINUITY_ZERO.TASK_TITLE_ID = hylanTaskDC.TASK_TITLE_ID;
                objTASK_CONTINUITY_ZERO.TASK_NAME = hylanTaskDC.TASK_NAME;
            }
            return objTASK_CONTINUITY_ZERO;
        }
        public override int Update(DBConnection Connection, List<HYLAN_TASKDC> objTASK_CONTINUITY_ZEROs)        
        {
            int updatedCount = 0;
            foreach (TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO in objTASK_CONTINUITY_ZEROs)
            {
                updatedCount = Update(Connection, objTASK_CONTINUITY_ZERO);
            }
            return updatedCount;
        }
		private int Update(DBConnection Connection, TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_CONTINUITY_ZEROUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_CONTINUITY_ZERO.REQUIRED);
			dbCommandWrapper.AddInParameter("p_EST_COMPLETION_DATE", DbType.DateTime, objTASK_CONTINUITY_ZERO.EST_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_CONTINUITY_ZERO.ACT_COMPLETION_DATE);
            dbCommandWrapper.AddInParameter("p_PARTY_RESPONSIBLE", DbType.String, objTASK_CONTINUITY_ZERO.PARTY_RESPONSIBLE);
			dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_CONTINUITY_ZERO.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_CONTINUITY_ZERO.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_CONTINUITY_ZERO.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_CONTINUITY_ZERO.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_CONTINUITY_ZERO.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_CONTINUITY_ZERO.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objTASK_CONTINUITY_ZERO.IsDirty = IsDirty = true;
            
			return updateCount;
        }
        public override int Insert(DBConnection Connection, List<HYLAN_TASKDC> objTASK_CONTINUITY_ZEROs)        
        {
            int insertCount = 0;
            foreach (TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO in objTASK_CONTINUITY_ZEROs)
            {
                 insertCount = Insert(Connection, objTASK_CONTINUITY_ZERO);
            }
            return  insertCount;
        }
		private int Insert(DBConnection Connection, TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_CONTINUITY_ZEROInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.TASK_ID);
			dbCommandWrapper.AddInParameter("p_JOB_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.JOB_ID);
			dbCommandWrapper.AddInParameter("p_TASK_TITLE_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.TASK_TITLE_ID);
			dbCommandWrapper.AddInParameter("p_REQUIRED", DbType.String, objTASK_CONTINUITY_ZERO.REQUIRED);
			dbCommandWrapper.AddInParameter("p_EST_COMPLETION_DATE", DbType.DateTime, objTASK_CONTINUITY_ZERO.EST_COMPLETION_DATE);
			dbCommandWrapper.AddInParameter("p_ACT_COMPLETION_DATE", DbType.DateTime, objTASK_CONTINUITY_ZERO.ACT_COMPLETION_DATE);
            dbCommandWrapper.AddInParameter("p_PARTY_RESPONSIBLE", DbType.String, objTASK_CONTINUITY_ZERO.PARTY_RESPONSIBLE);
            dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objTASK_CONTINUITY_ZERO.NOTES);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objTASK_CONTINUITY_ZERO.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objTASK_CONTINUITY_ZERO.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objTASK_CONTINUITY_ZERO.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objTASK_CONTINUITY_ZERO.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objTASK_CONTINUITY_ZERO.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public override int Delete(DBConnection Connection, List<HYLAN_TASKDC> objTASK_CONTINUITY_ZEROs)        
        {
            int deleteCount = 0;
            foreach (TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO in objTASK_CONTINUITY_ZEROs)
            {
                 deleteCount = Delete(Connection, objTASK_CONTINUITY_ZERO);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, TASK_CONTINUITY_ZERODC objTASK_CONTINUITY_ZERO)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_TASK_CONTINUITY_ZERODelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_TASK_ID", DbType.Int32, objTASK_CONTINUITY_ZERO.TASK_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
	}
}