
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/20/2015 7:01:28 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using EPay.DataClasses;
using EPay.Common;
using EPay.DataAccess;

namespace EPay.DataAccess
{		
	public partial class USERDA
	{
		public bool IsDirty {get; set;}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public List<USERDC> LoadAll(string ROLE_NAME, DBConnection Connection)
		{
			List<USERDC> objUSER = new List<USERDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_USERSLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
                             dbCommandWrapper.AddInParameter("ROLE_NAME", DbType.String, ROLE_NAME);
 
            DataSet ds = new DataSet();
			
			if (Connection.Transaction != null)
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            if (ds.Tables[0].Rows.Count > 0)
            {


                foreach (DataRow drRow in ds.Tables[0].Rows)
                {
                    objUSER.Add(FillObject(drRow));
                }   
            }
				
            return objUSER;
		}		
		public USERDC LoadByPrimaryKey(DBConnection Connection, int USER_ID)
		{
			USERDC objUSER = new USERDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_USERSLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
						dbCommandWrapper.AddInParameter("p_USER_ID", DbType.Int32, USER_ID);
 				

			IDataReader reader = null;

			if (Connection.Transaction != null)
				reader = Connection.dataBase.ExecuteReader(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				reader = Connection.dataBase.ExecuteReader(dbCommandWrapper.DBCommand);

			objUSER = FillObject(reader);
            return objUSER;
		}
		public int Update(DBConnection Connection, List<USERDC> objUSERs)        
        {
            int updatedCount = 0;
            foreach (USERDC objUSER in objUSERs)
            {
                updatedCount = Update(Connection, objUSER);
            }
            return updatedCount;
        }
		public int Update(DBConnection Connection, USERDC objUSER)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_USERSUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_USER_ID", DbType.Int32, objUSER.USER_ID);
			dbCommandWrapper.AddInParameter("p_USER_NAME", DbType.String, objUSER.USER_NAME);
			dbCommandWrapper.AddInParameter("p_PASSWORD", DbType.String, objUSER.PASSWORD);
			dbCommandWrapper.AddInParameter("p_FIRST_NAME", DbType.String, objUSER.FIRST_NAME);
			dbCommandWrapper.AddInParameter("p_LAST_NAME", DbType.String, objUSER.LAST_NAME);
			dbCommandWrapper.AddInParameter("p_ROLE_ID", DbType.Int32, objUSER.ROLE.ROLE_ID);
			dbCommandWrapper.AddInParameter("p_EMAIL_ADDRESS", DbType.String, objUSER.EMAIL_ADDRESS);
			dbCommandWrapper.AddInParameter("p_OFFICE_PHONE", DbType.String, objUSER.OFFICE_PHONE);
			dbCommandWrapper.AddInParameter("p_MOBILE_PHONE", DbType.String, objUSER.MOBILE_PHONE);
			dbCommandWrapper.AddInParameter("p_SECURITY_QUESTION", DbType.String, objUSER.SECURITY_QUESTION);
			dbCommandWrapper.AddInParameter("p_ANSWER", DbType.String, objUSER.ANSWER);
			dbCommandWrapper.AddInParameter("p_STATUS", DbType.String, objUSER.STATUS);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objUSER.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_lock_counter", DbType.Int32, objUSER.LOCK_COUNTER);
            dbCommandWrapper.AddInParameter("p_USER_COMPANY_ID", DbType.Int32, objUSER.USER_COMPANY_ID);
            
            try
            {
                if (Connection.Transaction != null)
                    updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
                else
                    updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

                if (updateCount == 0)
                {
                    objUSER.IsDirty = IsDirty = true;
                    throw new Exception(Constants.ConcurrencyMessageSingleRow);
                }
            }

            catch (Exception exp)
            {
                //Utilities.InsertIntoErrorLog("Error: USER UPDATE ", exp.Message + "\r\n" + exp.StackTrace, objUSER.MODIFIED_BY);
                objUSER.SetError(exp);
                throw exp;
            }
            
			return updateCount;
        }
		public int Insert(DBConnection Connection, List<USERDC> objUSERs)        
        {
            int insertCount = 0;
            foreach (USERDC objUSER in objUSERs)
            {
                 insertCount = Insert(Connection, objUSER);
            }
            return  insertCount;
        }
		public int Insert(DBConnection Connection, USERDC objUSER)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_USERSInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
			
            
			dbCommandWrapper.AddOutParameter("p_USER_ID", DbType.Int32, Int32.MaxValue);
			dbCommandWrapper.AddInParameter("p_USER_NAME", DbType.String, objUSER.USER_NAME);
            dbCommandWrapper.AddInParameter("p_PASSWORD", DbType.String, Encryptor.Encrypt(objUSER.PASSWORD));
			dbCommandWrapper.AddInParameter("p_FIRST_NAME", DbType.String, objUSER.FIRST_NAME);
			dbCommandWrapper.AddInParameter("p_LAST_NAME", DbType.String, objUSER.LAST_NAME);
			dbCommandWrapper.AddInParameter("p_ROLE_ID", DbType.Int32, objUSER.ROLE.ROLE_ID);
			dbCommandWrapper.AddInParameter("p_EMAIL_ADDRESS", DbType.String, objUSER.EMAIL_ADDRESS);
			dbCommandWrapper.AddInParameter("p_OFFICE_PHONE", DbType.String, objUSER.OFFICE_PHONE);
			dbCommandWrapper.AddInParameter("p_MOBILE_PHONE", DbType.String, objUSER.MOBILE_PHONE);
			dbCommandWrapper.AddInParameter("p_SECURITY_QUESTION", DbType.String, objUSER.SECURITY_QUESTION);
			dbCommandWrapper.AddInParameter("p_ANSWER", DbType.String, objUSER.ANSWER);
			dbCommandWrapper.AddInParameter("p_STATUS", DbType.String, objUSER.STATUS);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objUSER.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_USER_COMPANY_ID", DbType.Int32, objUSER.USER_COMPANY_ID);

            try
            {
                if (Connection.Transaction != null)
                    insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
                else
                    insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
            }
            catch (Exception exp)
            {
                //Utilities.InsertIntoErrorLog("Error: USER INSERTION ", exp.Message + "\r\n" + exp.StackTrace, objUSER.MODIFIED_BY);
                objUSER.SetError(exp);
                throw exp;
            }

            objUSER.USER_ID = (int)dbCommandWrapper.DBCommand.Parameters["@p_USER_ID"].Value;

            return insertCount;
        }
		public int Delete(DBConnection Connection, List<USERDC> objUSERs)        
        {
            int deleteCount = 0;
            foreach (USERDC objUSER in objUSERs)
            {
                 deleteCount = Delete(Connection, objUSER);
            }
            return  deleteCount;
        }
		private int Delete(DBConnection Connection, USERDC objUSER)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_USERSDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_USER_ID", DbType.Int32, objUSER.USER_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
		private USERDC FillObject(IDataReader reader)
        {
			USERDC objUSER = null;
            if (reader != null && reader.Read())
            {	
				objUSER = new USERDC();
				objUSER.USER_ID = (int)reader["USER_ID"];
				objUSER.USER_NAME = (String)reader["USER_NAME"];
				objUSER.PASSWORD = (String)reader["PASSWORD"];
				objUSER.FIRST_NAME = (String)reader["FIRST_NAME"];
				objUSER.LAST_NAME = (String)reader["LAST_NAME"];
				objUSER.ROLE.ROLE_ID = (int)reader["ROLE_ID"];
                objUSER.ROLE.ROLE_NAME = (String)reader["ROLE_NAME"];
                objUSER.USER_COMPANIES = reader["COMPANIES"] == DBNull.Value ? new int[] { } : Array.ConvertAll<string, int>(((String)reader["COMPANIES"]).Split(','), Convert.ToInt32);
				objUSER.EMAIL_ADDRESS = (String)reader["EMAIL_ADDRESS"];
				objUSER.OFFICE_PHONE = reader["OFFICE_PHONE"] == DBNull.Value ? null : (String)reader["OFFICE_PHONE"];
				objUSER.MOBILE_PHONE = reader["MOBILE_PHONE"] == DBNull.Value ? null : (String)reader["MOBILE_PHONE"];
				objUSER.SECURITY_QUESTION = reader["SECURITY_QUESTION"] == DBNull.Value ? null : (String)reader["SECURITY_QUESTION"];
				objUSER.ANSWER = reader["ANSWER"] == DBNull.Value ? null : (String)reader["ANSWER"];
				objUSER.STATUS = (String)reader["STATUS"];
				objUSER.CREATED_ON = (DateTime)reader["CREATED_ON"];
				objUSER.CREATED_BY = (int)reader["CREATED_BY"];
				objUSER.MODIFIED_ON = (DateTime)reader["MODIFIED_ON"];
				objUSER.MODIFIED_BY = (int)reader["MODIFIED_BY"];
                objUSER.LOCK_COUNTER = (!string.IsNullOrEmpty(reader["LOCK_COUNTER"].ToString()) ? (int)reader["LOCK_COUNTER"] : 0);
                objUSER.USER_COMPANY_ID = reader["USER_COMPANY_ID"] == DBNull.Value ? null : (int?)reader["USER_COMPANY_ID"];
                reader.Close();
                reader.Dispose();
            }
            return objUSER;
        }
		private USERDC FillObject(DataRow row)
        {
			USERDC objUSER = null;
			objUSER = new USERDC();
			objUSER.USER_ID = (int)row["USER_ID"];
			objUSER.USER_NAME = (String)row["USER_NAME"];
            if (row.Table.Columns.Contains("PASSWORD"))
            {
                objUSER.PASSWORD = (String)row["PASSWORD"];
            }
			objUSER.FIRST_NAME = (String)row["FIRST_NAME"];
			objUSER.LAST_NAME = (String)row["LAST_NAME"];
            if (row.Table.Columns.Contains("ROLE_ID"))
            {
                objUSER.ROLE.ROLE_ID = (int)row["ROLE_ID"];
            }
            if (row.Table.Columns.Contains("IS_RESTRICTED"))
            {
                objUSER.ROLE.IS_RESTRICTED = (row["IS_RESTRICTED"] == DBNull.Value) ? false : Convert.ToBoolean(row["IS_RESTRICTED"]);
            }
            objUSER.ROLE.ROLE_NAME = (String)row["ROLE_NAME"];
            if (row.Table.Columns.Contains("COMPANIES"))
            {
                objUSER.USER_COMPANIES = row["COMPANIES"] == DBNull.Value ? new int[] { } : Array.ConvertAll<string, int>(((String)row["COMPANIES"]).Split(','), Convert.ToInt32);
            }
            if (row.Table.Columns.Contains("COMPANIES_NAMES"))
            {
                objUSER.USER_COMPANIES_NAMES = (row["COMPANIES_NAMES"] == DBNull.Value) ? "" : Convert.ToString(row["COMPANIES_NAMES"]);
            }
			objUSER.EMAIL_ADDRESS = (String)row["EMAIL_ADDRESS"];
			objUSER.OFFICE_PHONE = row["OFFICE_PHONE"] == DBNull.Value ? null : (String)row["OFFICE_PHONE"];
			objUSER.MOBILE_PHONE = row["MOBILE_PHONE"] == DBNull.Value ? null : (String)row["MOBILE_PHONE"];
            if (row.Table.Columns.Contains("SECURITY_QUESTION"))
            {
                objUSER.SECURITY_QUESTION = row["SECURITY_QUESTION"] == DBNull.Value ? null : (String)row["SECURITY_QUESTION"];
            }
            if (row.Table.Columns.Contains("ANSWER"))
            {
                objUSER.ANSWER = row["ANSWER"] == DBNull.Value ? null : (String)row["ANSWER"];
            }
			objUSER.STATUS = (String)row["STATUS"];
            if (row.Table.Columns.Contains("CREATED_ON"))
            {
                objUSER.CREATED_ON = (DateTime)row["CREATED_ON"];
            }
            if (row.Table.Columns.Contains("CREATED_BY"))
            {
                objUSER.CREATED_BY = (int)row["CREATED_BY"];
            }
            if (row.Table.Columns.Contains("MODIFIED_ON"))
            {
                objUSER.MODIFIED_ON = (DateTime)row["MODIFIED_ON"];
            }
            if (row.Table.Columns.Contains("MODIFIED_BY"))
            {
                objUSER.MODIFIED_BY = (int)row["MODIFIED_BY"];
            }
            if (row.Table.Columns.Contains("LOCK_COUNTER"))
            {
                objUSER.LOCK_COUNTER = (!string.IsNullOrEmpty(row["LOCK_COUNTER"].ToString()) ? (int)row["LOCK_COUNTER"] : 0);
            }
            if (row.Table.Columns.Contains("SCREENS"))
            {
                objUSER.USER_SCREENS = row["SCREENS"] == DBNull.Value ? new int[] { } : Array.ConvertAll<string, int>(((String)row["SCREENS"]).Split(','), Convert.ToInt32);
            }
            if (row.Table.Columns.Contains("PASSWORD_MODIFIED_ON"))
            {
                objUSER.PASSWORD_MODIFIED_ON = (DateTime)row["PASSWORD_MODIFIED_ON"];
            }
            if (row.Table.Columns.Contains("PASSWORD_AGE"))
            {
                objUSER.PASSWORD_AGE = Convert.ToDouble(row["PASSWORD_AGE"]);
            }
            if (row.Table.Columns.Contains("HOME_RMAGS"))
            {
                objUSER.HOME_RMAGS = row["HOME_RMAGS"] == DBNull.Value ? new int[] { } : Array.ConvertAll<string, int>(((String)row["HOME_RMAGS"]).Split(','), Convert.ToInt32);
            }
            if (row.Table.Columns.Contains("USER_COMPANY_ID"))
            {
                objUSER.USER_COMPANY_ID = row["USER_COMPANY_ID"] == DBNull.Value ? null : (int?)row["USER_COMPANY_ID"];
            }
            return objUSER;
        }
	}
}