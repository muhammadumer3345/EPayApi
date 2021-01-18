
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/8/2017 3:14:28 PM
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
	public class DAILY_UNKNOWNDA
	{
		public bool IsDirty {get; set;}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public List<DAILY_UNKNOWNDC> LoadAll(DBConnection Connection)
		{
			List<DAILY_UNKNOWNDC> objDAILY_UNKNOW = new List<DAILY_UNKNOWNDC>();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_DAILY_UNKNOWNLoadAll");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
 
 
            DataSet ds = new DataSet();
			
			if (Connection.Transaction != null)
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
			else
				ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);
			
			  foreach (DataRow drRow in ds.Tables[0].Rows)
                {
				objDAILY_UNKNOW.Add(FillObject(drRow));
				}
				
            return objDAILY_UNKNOW;
		}
		
		public DAILY_UNKNOWNDC LoadByPrimaryKey(DBConnection Connection, int DU_DAILY_ID)
		{
			DAILY_UNKNOWNDC objDAILY_UNKNOW = new DAILY_UNKNOWNDC();
			StringBuilder sql = new StringBuilder();
			sql.Append("proc_DAILY_UNKNOWNLoadByPrimaryKey");

			DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
						dbCommandWrapper.AddInParameter("p_DU_DAILY_ID", DbType.Int32, DU_DAILY_ID);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objDAILY_UNKNOW = (Utility.ConvertToObject<DAILY_UNKNOWNDC>(ds.Tables[0]));
            return objDAILY_UNKNOW;
		}

        public DAILY_UNKNOWNDC LoadByDailyID(DBConnection Connection, int DAILY_ID)
        {
            DAILY_UNKNOWNDC objDAILY_UNKNOW = new DAILY_UNKNOWNDC();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_DAILY_UNKNOWNLoadByDailyID");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, DAILY_ID);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);
            
            objDAILY_UNKNOW = (Utility.ConvertToObject<DAILY_UNKNOWNDC>(ds.Tables[0]));
            return objDAILY_UNKNOW;
        }
		public int Update(DBConnection Connection, DAILYDC objDAILY_UNKNOW)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_DAILY_UNKNOWNUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_DU_DAILY_ID", DbType.Int32, objDAILY_UNKNOW.DU_DAILY_ID);
			dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objDAILY_UNKNOW.DAILY_ID);
			dbCommandWrapper.AddInParameter("p_NODE_ID1", DbType.String, objDAILY_UNKNOW.NODE_ID1);
			dbCommandWrapper.AddInParameter("p_NODE_ID2", DbType.String, objDAILY_UNKNOW.NODE_ID2);
			dbCommandWrapper.AddInParameter("p_NODE_ID3", DbType.String, objDAILY_UNKNOW.NODE_ID3);
			dbCommandWrapper.AddInParameter("p_HUB", DbType.String, objDAILY_UNKNOW.HUB);
			dbCommandWrapper.AddInParameter("p_HYLAN_PM", DbType.Int32, objDAILY_UNKNOW.HYLAN_PM);
			dbCommandWrapper.AddInParameter("p_STREET_ADDRESS", DbType.String, objDAILY_UNKNOW.STREET_ADDRESS);
			dbCommandWrapper.AddInParameter("p_CITY", DbType.String, objDAILY_UNKNOW.CITY);
			dbCommandWrapper.AddInParameter("p_STATE", DbType.String, objDAILY_UNKNOW.STATE);
			dbCommandWrapper.AddInParameter("p_ZIP", DbType.String, objDAILY_UNKNOW.ZIP);
			dbCommandWrapper.AddInParameter("p_LAT", DbType.String, objDAILY_UNKNOW.LAT);
			dbCommandWrapper.AddInParameter("p_LONG", DbType.String, objDAILY_UNKNOW.LONG);
			dbCommandWrapper.AddInParameter("p_POLE_LOCATION", DbType.String, objDAILY_UNKNOW.POLE_LOCATION);
			dbCommandWrapper.AddInParameter("p_CLIENT_PM", DbType.String, objDAILY_UNKNOW.CLIENT_PM);
			dbCommandWrapper.AddInParameter("p_UNKNOWN_STATUS", DbType.Int32, objDAILY_UNKNOW.STATUS);
			dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objDAILY_UNKNOW.CREATED_ON);
			dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objDAILY_UNKNOW.CREATED_BY);
			dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objDAILY_UNKNOW.MODIFIED_ON);
			dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objDAILY_UNKNOW.MODIFIED_BY);
			dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objDAILY_UNKNOW.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);
			
			if (updateCount == 0)
                objDAILY_UNKNOW.IsDirty = IsDirty = true;
            
			return updateCount;
        }
		
        public int Insert(DBConnection Connection, DAILYDC objDAILY_UNKNOW)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_DAILY_UNKNOWNInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objDAILY_UNKNOW.DAILY_ID);
            dbCommandWrapper.AddInParameter("p_NODE_ID1", DbType.String, objDAILY_UNKNOW.NODE_ID1);
            dbCommandWrapper.AddInParameter("p_NODE_ID2", DbType.String, objDAILY_UNKNOW.NODE_ID2);
            dbCommandWrapper.AddInParameter("p_NODE_ID3", DbType.String, objDAILY_UNKNOW.NODE_ID3);
            dbCommandWrapper.AddInParameter("p_HUB", DbType.String, objDAILY_UNKNOW.HUB);
            dbCommandWrapper.AddInParameter("p_HYLAN_PM", DbType.Int32, objDAILY_UNKNOW.HYLAN_PM);
            dbCommandWrapper.AddInParameter("p_STREET_ADDRESS", DbType.String, objDAILY_UNKNOW.STREET_ADDRESS);
            dbCommandWrapper.AddInParameter("p_CITY", DbType.String, objDAILY_UNKNOW.CITY);
            dbCommandWrapper.AddInParameter("p_STATE", DbType.String, objDAILY_UNKNOW.STATE);
            dbCommandWrapper.AddInParameter("p_ZIP", DbType.String, objDAILY_UNKNOW.ZIP);
            dbCommandWrapper.AddInParameter("p_LAT", DbType.String, objDAILY_UNKNOW.LAT);
            dbCommandWrapper.AddInParameter("p_LONG", DbType.String, objDAILY_UNKNOW.LONG);
            dbCommandWrapper.AddInParameter("p_POLE_LOCATION", DbType.String, objDAILY_UNKNOW.POLE_LOCATION);
            dbCommandWrapper.AddInParameter("p_CLIENT_PM", DbType.String, objDAILY_UNKNOW.CLIENT_PM);
            dbCommandWrapper.AddInParameter("p_UNKNOWN_STATUS", DbType.Int32, objDAILY_UNKNOW.STATUS); // Temporay - To be changed after discussion
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objDAILY_UNKNOW.CREATED_ON);
            dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objDAILY_UNKNOW.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objDAILY_UNKNOW.MODIFIED_ON);
            dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objDAILY_UNKNOW.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objDAILY_UNKNOW.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        
		public int Delete(DBConnection Connection, List<DAILY_UNKNOWNDC> objDAILY_UNKNOWs)        
        {
            int deleteCount = 0;
            foreach (DAILY_UNKNOWNDC objDAILY_UNKNOW in objDAILY_UNKNOWs)
            {
                 deleteCount = Delete(Connection, objDAILY_UNKNOW);
            }
            return  deleteCount;
        }
		public int Delete(DBConnection Connection, DAILY_UNKNOWNDC objDAILY_UNKNOW)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_DAILY_UNKNOWNDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            
			dbCommandWrapper.AddInParameter("p_DU_DAILY_ID", DbType.Int32, objDAILY_UNKNOW.DU_DAILY_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
		private DAILY_UNKNOWNDC FillObject(IDataReader reader)
        {
			DAILY_UNKNOWNDC objDAILY_UNKNOW = null;
            if (reader != null && reader.Read())
            {	
				objDAILY_UNKNOW = new DAILY_UNKNOWNDC();
				objDAILY_UNKNOW.DU_DAILY_ID = (int)reader["DU_DAILY_ID"];
				objDAILY_UNKNOW.DAILY_ID = (int)reader["DAILY_ID"];
				objDAILY_UNKNOW.NODE_ID1 = (String)reader["NODE_ID1"];
				objDAILY_UNKNOW.NODE_ID2 = (String)reader["NODE_ID2"];
				objDAILY_UNKNOW.NODE_ID3 = (String)reader["NODE_ID3"];
				objDAILY_UNKNOW.HUB = (String)reader["HUB"];
				objDAILY_UNKNOW.HYLAN_PM = reader["HYLAN_PM"] == DBNull.Value ? null : (int?)reader["HYLAN_PM"];
				objDAILY_UNKNOW.STREET_ADDRESS = (String)reader["STREET_ADDRESS"];
				objDAILY_UNKNOW.CITY = (String)reader["CITY"];
				objDAILY_UNKNOW.STATE = (String)reader["STATE"];
				objDAILY_UNKNOW.ZIP = reader["ZIP"] == DBNull.Value ? null : (String)reader["ZIP"];
				objDAILY_UNKNOW.LAT = (String)reader["LAT"];
				objDAILY_UNKNOW.LONG = (String)reader["LONG"];
				objDAILY_UNKNOW.POLE_LOCATION = (String)reader["POLE_LOCATION"];
				objDAILY_UNKNOW.CLIENT_PM = (String)reader["CLIENT_PM"];
				objDAILY_UNKNOW.UNKNOWN_STATUS = (int)reader["UNKNOWN_STATUS"];
				objDAILY_UNKNOW.CREATED_ON = (DateTime)reader["CREATED_ON"];
				objDAILY_UNKNOW.CREATED_BY = (int)reader["CREATED_BY"];
				objDAILY_UNKNOW.MODIFIED_ON = (DateTime)reader["MODIFIED_ON"];
				objDAILY_UNKNOW.MODIFIED_BY = (int)reader["MODIFIED_BY"];
				objDAILY_UNKNOW.LOCK_COUNTER = (int)reader["LOCK_COUNTER"];

                reader.Close();
                reader.Dispose();
            }
            return objDAILY_UNKNOW;
        }
		private DAILY_UNKNOWNDC FillObject(DataRow row)
        {
			DAILY_UNKNOWNDC objDAILY_UNKNOW = null;
			objDAILY_UNKNOW = new DAILY_UNKNOWNDC();
			objDAILY_UNKNOW.DU_DAILY_ID = (int)row["DU_DAILY_ID"];
			objDAILY_UNKNOW.DAILY_ID = (int)row["DAILY_ID"];
			objDAILY_UNKNOW.NODE_ID1 = (String)row["NODE_ID1"];
			objDAILY_UNKNOW.NODE_ID2 = (String)row["NODE_ID2"];
			objDAILY_UNKNOW.NODE_ID3 = (String)row["NODE_ID3"];
			objDAILY_UNKNOW.HUB = (String)row["HUB"];
			objDAILY_UNKNOW.HYLAN_PM = row["HYLAN_PM"] == DBNull.Value ? null : (int?)row["HYLAN_PM"];
			objDAILY_UNKNOW.STREET_ADDRESS = (String)row["STREET_ADDRESS"];
			objDAILY_UNKNOW.CITY = (String)row["CITY"];
			objDAILY_UNKNOW.STATE = (String)row["STATE"];
			objDAILY_UNKNOW.ZIP = row["ZIP"] == DBNull.Value ? null : (String)row["ZIP"];
			objDAILY_UNKNOW.LAT = (String)row["LAT"];
			objDAILY_UNKNOW.LONG = (String)row["LONG"];
			objDAILY_UNKNOW.POLE_LOCATION = (String)row["POLE_LOCATION"];
			objDAILY_UNKNOW.CLIENT_PM = (String)row["CLIENT_PM"];
			objDAILY_UNKNOW.UNKNOWN_STATUS = (int)row["UNKNOWN_STATUS"];
			objDAILY_UNKNOW.CREATED_ON = (DateTime)row["CREATED_ON"];
			objDAILY_UNKNOW.CREATED_BY = (int)row["CREATED_BY"];
			objDAILY_UNKNOW.MODIFIED_ON = (DateTime)row["MODIFIED_ON"];
			objDAILY_UNKNOW.MODIFIED_BY = (int)row["MODIFIED_BY"];
			objDAILY_UNKNOW.LOCK_COUNTER = (int)row["LOCK_COUNTER"];

            return objDAILY_UNKNOW;
        }
	}
}