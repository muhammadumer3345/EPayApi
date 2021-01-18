
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/6/2017 2:36:35 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using EPay.DataClasses;
using EPay.Common;
using System.Linq;

namespace EPay.DataAccess
{		
	public class MAN_POWERDA
	{
		public bool IsDirty {get; set;}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public List<MAN_POWERDC> LoadAll(DBConnection Connection)
		{
			List<MAN_POWERDC> objMAN_POWE = new List<MAN_POWERDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_MAN_POWERLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
 
 
            DataSet ds = new DataSet();
			
			if (Connection.Transaction != null)
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);
			
			  foreach (DataRow drRow in ds.Tables[0].Rows)
                {
				objMAN_POWE.Add(FillObject(drRow));
				}
				
            return objMAN_POWE;
		}
		
		public MAN_POWERDC LoadByPrimaryKey(DBConnection Connection, int MAN_POWER_ID)
		{
			MAN_POWERDC objMAN_POWE = new MAN_POWERDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_MAN_POWERLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
						dbCommandWrapper.AddInParameter("p_MAN_POWER_ID", DbType.Int32, MAN_POWER_ID);
 				

			IDataReader reader = null;

			if (Connection.Transaction != null)
				reader = Connection.dataBase.ExecuteReader(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				reader = Connection.dataBase.ExecuteReader(dbCommandWrapper.DBCommand);

			objMAN_POWE = FillObject(reader);
            return objMAN_POWE;
		}
        public List<MAN_POWERDC> LoadByDailyID(DBConnection Connection, int DAILY_ID)
        {
            List<MAN_POWERDC> objMAN_POWE = new List<MAN_POWERDC>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_MAN_POWERLoadByDailyID");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, DAILY_ID);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objMAN_POWE = (Utility.ConvertToObjects<MAN_POWERDC>(ds.Tables[0]));
            return objMAN_POWE;
        }

        public List<String> LoadNames(DBConnection Connection, string Column_Name, string Column_Value)
        {
            List<String> names = new List<string>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_MAN_POWER_AJAX");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_NAME", DbType.String, Column_Value);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            if(ds.Tables.Count > 0)
            {
                names = ds.Tables[0].AsEnumerable().Select(r => r.Field<string>(Column_Name)).ToList();
            }
            return names;
        }
        public int Update(DBConnection Connection, List<MAN_POWERDC> objMAN_POWEs)        
        {
            int updatedCount = 0;
            foreach (MAN_POWERDC objMAN_POWE in objMAN_POWEs)
            {
                updatedCount = Update(Connection, objMAN_POWE);
            }
            return updatedCount;
        }
		public int Update(DBConnection Connection, MAN_POWERDC objMAN_POWE)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_MAN_POWERUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);


            dbCommandWrapper.AddInParameter("p_MAN_POWER_ID", DbType.Int32, objMAN_POWE.MAN_POWER_ID);
			dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objMAN_POWE.DAILY_ID);
			dbCommandWrapper.AddInParameter("p_FIRST_NAME", DbType.String, objMAN_POWE.FIRST_NAME);
			dbCommandWrapper.AddInParameter("p_LAST_NAME", DbType.String, objMAN_POWE.LAST_NAME);
			dbCommandWrapper.AddInParameter("p_ST_HOURS", DbType.Decimal, objMAN_POWE.ST_HOURS);
			dbCommandWrapper.AddInParameter("p_OT_HOURS", DbType.Decimal, objMAN_POWE.OT_HOURS);
			dbCommandWrapper.AddInParameter("p_HOURS_DIFF", DbType.Decimal, objMAN_POWE.HOURS_DIFF);
            dbCommandWrapper.AddInParameter("p_MAN_POWER_JOB_TYPE", DbType.Decimal, objMAN_POWE.MAN_POWER_JOB_TYPE);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objMAN_POWE.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objMAN_POWE.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objMAN_POWE.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objMAN_POWE.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objMAN_POWE.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objMAN_POWE.IsDirty = IsDirty = true;
            
			return updateCount;
        }
		public int Insert(DBConnection Connection, List<MAN_POWERDC> objMAN_POWEs)        
        {
            int insertCount = 0;
            foreach (MAN_POWERDC objMAN_POWE in objMAN_POWEs)
            {
                 insertCount = Insert(Connection, objMAN_POWE);
            }
            return  insertCount;
        }
        public int Insert(DBConnection Connection, MAN_POWERDC objMAN_POWE)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_MAN_POWERInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddOutParameter("p_MAN_POWER_ID", DbType.Int32, objMAN_POWE.MAN_POWER_ID);
			dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objMAN_POWE.DAILY_ID);
			dbCommandWrapper.AddInParameter("p_FIRST_NAME", DbType.String, objMAN_POWE.FIRST_NAME);
			dbCommandWrapper.AddInParameter("p_LAST_NAME", DbType.String, objMAN_POWE.LAST_NAME);
			dbCommandWrapper.AddInParameter("p_ST_HOURS", DbType.Decimal, objMAN_POWE.ST_HOURS);
			dbCommandWrapper.AddInParameter("p_OT_HOURS", DbType.Decimal, objMAN_POWE.OT_HOURS);
			dbCommandWrapper.AddInParameter("p_HOURS_DIFF", DbType.Decimal, objMAN_POWE.HOURS_DIFF);
            dbCommandWrapper.AddInParameter("p_MAN_POWER_JOB_TYPE", DbType.Decimal, objMAN_POWE.MAN_POWER_JOB_TYPE);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objMAN_POWE.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objMAN_POWE.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objMAN_POWE.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objMAN_POWE.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objMAN_POWE.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
		public int Delete(DBConnection Connection, List<MAN_POWERDC> objMAN_POWEs)        
        {
            int deleteCount = 0;
            int dailyID = 0;
            int deletedBy = 0;
            int updatedLockCounter = 0;
            if (objMAN_POWEs.Count > 0)
            {
                dailyID = objMAN_POWEs[0].DAILY_ID;
                deletedBy = objMAN_POWEs[0].MODIFIED_BY;
            }
            foreach (MAN_POWERDC objMAN_POWE in objMAN_POWEs)
            {
                 deleteCount = Delete(Connection, objMAN_POWE);
            }
            if (deleteCount > 0) //update daily's datetime and lockcounter
            {
                DAILYDA dailyDAL = new DAILYDA();
                var dailyDC = dailyDAL.LoadByPrimaryKey(Connection,dailyID);
                DateTime currentDateTime = DateTime.Now;
                dailyDC.MODIFIED_ON = currentDateTime;
                dailyDC.MODIFIED_BY = deletedBy;
                int updatedCount = dailyDAL.Update(Connection, dailyDC);

                updatedLockCounter = dailyDAL.LoadByPrimaryKey(Connection, dailyID).LOCK_COUNTER;
            }
            return updatedLockCounter;
        }
		private int Delete(DBConnection Connection, MAN_POWERDC objMAN_POWE)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_MAN_POWERDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_MAN_POWER_ID", DbType.Int32, objMAN_POWE.MAN_POWER_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
		private MAN_POWERDC FillObject(IDataReader reader)
        {
			MAN_POWERDC objMAN_POWE = null;
            if (reader != null && reader.Read())
            {	
				objMAN_POWE = new MAN_POWERDC();
				objMAN_POWE.MAN_POWER_ID = (int)reader["MAN_POWER_ID"];
				objMAN_POWE.DAILY_ID = (int)reader["DAILY_ID"];
				objMAN_POWE.FIRST_NAME = (String)reader["FIRST_NAME"];
				objMAN_POWE.LAST_NAME = (String)reader["LAST_NAME"];
				objMAN_POWE.ST_HOURS = (Decimal)reader["ST_HOURS"];
				objMAN_POWE.OT_HOURS = (Decimal)reader["OT_HOURS"];
				objMAN_POWE.HOURS_DIFF = (Decimal)reader["HOURS_DIFF"];
                objMAN_POWE.MAN_POWER_JOB_TYPE = (int)reader["MAN_POWER_JOB_TYPE"];
                objMAN_POWE.CREATED_ON = (DateTime)reader["CREATED_ON"];
				objMAN_POWE.CREATED_BY = (int)reader["CREATED_BY"];
				objMAN_POWE.MODIFIED_ON = (DateTime)reader["MODIFIED_ON"];
				objMAN_POWE.MODIFIED_BY = (int)reader["MODIFIED_BY"];
				objMAN_POWE.LOCK_COUNTER = (int)reader["LOCK_COUNTER"];

                reader.Close();
                reader.Dispose();
            }
            return objMAN_POWE;
        }
		private MAN_POWERDC FillObject(DataRow row)
        {
			MAN_POWERDC objMAN_POWE = null;
			objMAN_POWE = new MAN_POWERDC();
			objMAN_POWE.MAN_POWER_ID = (int)row["MAN_POWER_ID"];
			objMAN_POWE.DAILY_ID = (int)row["DAILY_ID"];
			objMAN_POWE.FIRST_NAME = (String)row["FIRST_NAME"];
			objMAN_POWE.LAST_NAME = (String)row["LAST_NAME"];
			objMAN_POWE.ST_HOURS = (Decimal)row["ST_HOURS"];
			objMAN_POWE.OT_HOURS = (Decimal)row["OT_HOURS"];
			objMAN_POWE.HOURS_DIFF = (Decimal)row["HOURS_DIFF"];
            objMAN_POWE.MAN_POWER_JOB_TYPE = (int)row["MAN_POWER_JOB_TYPE"];
            objMAN_POWE.CREATED_ON = (DateTime)row["CREATED_ON"];
			objMAN_POWE.CREATED_BY = (int)row["CREATED_BY"];
			objMAN_POWE.MODIFIED_ON = (DateTime)row["MODIFIED_ON"];
			objMAN_POWE.MODIFIED_BY = (int)row["MODIFIED_BY"];
			objMAN_POWE.LOCK_COUNTER = (int)row["LOCK_COUNTER"];

            return objMAN_POWE;
        }
	}
}
