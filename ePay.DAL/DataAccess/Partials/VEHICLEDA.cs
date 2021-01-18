
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

namespace EPay.DataAccess
{
    public class VEHICLEDA
    {
        public bool IsDirty { get; set; }

        //=================================================================
        //  	public Function LoadAll() As Boolean
        //=================================================================
        //  Loads all of the records in the database, and sets the currentRow to the first row
        //=================================================================
        public List<VEHICLEDC> LoadAll(DBConnection Connection)
        {
            List<VEHICLEDC> objVEHICLE_VALU = new List<VEHICLEDC>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_VEHICLE_VALUELoadAll");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            foreach (DataRow drRow in ds.Tables[0].Rows)
            {
                objVEHICLE_VALU.Add(FillObject(drRow));
            }

            return objVEHICLE_VALU;
        }

        public List<VEHICLEDC> LoadByDailyIDAndType(DBConnection Connection, int DAILY_ID, int DAILY_TYPE)
        {
            List<VEHICLEDC> objVEHICLE_VALU = new List<VEHICLEDC>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_VEHICLE_VALUELoadByDailyIDAndType");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, DAILY_ID);
            dbCommandWrapper.AddInParameter("p_DAILY_TYPE", DbType.Int32, DAILY_TYPE);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            objVEHICLE_VALU = (Utility.ConvertToObjects<VEHICLEDC>(ds.Tables[0]));

            
            return objVEHICLE_VALU;
        }
        public int Update(DBConnection Connection, List<VEHICLEDC> objVEHICLE_VALUs)
        {
            int updatedCount = 0;
            foreach (VEHICLEDC objVEHICLE_VALU in objVEHICLE_VALUs)
            {
                updatedCount = Update(Connection, objVEHICLE_VALU);
            }
            return updatedCount;
        }
        public int Update(DBConnection Connection, VEHICLEDC objVEHICLE_VALU)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_VEHICLE_VALUEUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);


            dbCommandWrapper.AddInParameter("p_VEHICLE_VALUE_ID", DbType.Int32, objVEHICLE_VALU.VEHICLE_VALUE_ID);
            dbCommandWrapper.AddInParameter("p_VEHICLE_ID", DbType.Int32, objVEHICLE_VALU.VEHICLE_ID);
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objVEHICLE_VALU.DAILY_ID);
            dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objVEHICLE_VALU.NOTES);
            dbCommandWrapper.AddInParameter("p_HOURS", DbType.Decimal, objVEHICLE_VALU.HOURS);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objVEHICLE_VALU.CREATED_ON);
            dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objVEHICLE_VALU.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objVEHICLE_VALU.MODIFIED_ON);
            dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objVEHICLE_VALU.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objVEHICLE_VALU.LOCK_COUNTER);


            if (Connection.Transaction != null)
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            if (updateCount == 0)
                objVEHICLE_VALU.IsDirty = IsDirty = true;

            return updateCount;
        }
        public int Insert(DBConnection Connection, List<VEHICLEDC> objVEHICLE_VALUs)
        {
            int insertCount = 0;
            foreach (VEHICLEDC objVEHICLE_VALU in objVEHICLE_VALUs)
            {
                insertCount = Insert(Connection, objVEHICLE_VALU);
            }
            return insertCount;
        }
        public int Insert(DBConnection Connection, VEHICLEDC objVEHICLE_VALU)
        {
            int insertCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_VEHICLE_VALUEInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);

            dbCommandWrapper.AddOutParameter("p_VEHICLE_VALUE_ID", DbType.Int32, objVEHICLE_VALU.VEHICLE_VALUE_ID);
            dbCommandWrapper.AddInParameter("p_VEHICLE_ID", DbType.Int32, objVEHICLE_VALU.VEHICLE_ID);
            dbCommandWrapper.AddInParameter("p_DAILY_ID", DbType.Int32, objVEHICLE_VALU.DAILY_ID);
            dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objVEHICLE_VALU.NOTES);
            dbCommandWrapper.AddInParameter("p_HOURS", DbType.Decimal, objVEHICLE_VALU.HOURS);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objVEHICLE_VALU.CREATED_ON);
            dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objVEHICLE_VALU.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objVEHICLE_VALU.MODIFIED_ON);
            dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objVEHICLE_VALU.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objVEHICLE_VALU.LOCK_COUNTER);


            if (Connection.Transaction != null)
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                insertCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return insertCount;
        }
        public int Delete(DBConnection Connection, List<VEHICLEDC> objVEHICLE_VALUs)
        {
            int deleteCount = 0;
            foreach (VEHICLEDC objVEHICLE_VALU in objVEHICLE_VALUs)
            {
                deleteCount = Delete(Connection, objVEHICLE_VALU);
            }
            return deleteCount;
        }
        private int Delete(DBConnection Connection, VEHICLEDC objVEHICLE_VALU)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_VEHICLE_VALUEDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);

            dbCommandWrapper.AddInParameter("p_VEHICLE_VALUE_ID", DbType.Int32, objVEHICLE_VALU.VEHICLE_VALUE_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
        private VEHICLEDC FillObject(IDataReader reader)
        {
            VEHICLEDC objVEHICLE_VALU = null;
            if (reader != null && reader.Read())
            {
                objVEHICLE_VALU = new VEHICLEDC();
                objVEHICLE_VALU.VEHICLE_VALUE_ID = (int)reader["VEHICLE_VALUE_ID"];
                objVEHICLE_VALU.VEHICLE_ID = (int)reader["VEHICLE_ID"];
                objVEHICLE_VALU.DAILY_ID = (int)reader["DAILY_ID"];
                objVEHICLE_VALU.NOTES = reader["NOTES"] == DBNull.Value ? null : (String)reader["NOTES"];
                objVEHICLE_VALU.HOURS = (Decimal)reader["HOURS"];
                objVEHICLE_VALU.CREATED_ON = (DateTime)reader["CREATED_ON"];
                objVEHICLE_VALU.CREATED_BY = (int)reader["CREATED_BY"];
                objVEHICLE_VALU.MODIFIED_ON = (DateTime)reader["MODIFIED_ON"];
                objVEHICLE_VALU.MODIFIED_BY = (int)reader["MODIFIED_BY"];
                objVEHICLE_VALU.LOCK_COUNTER = (int)reader["LOCK_COUNTER"];

                reader.Close();
                reader.Dispose();
            }
            return objVEHICLE_VALU;
        }
        private VEHICLEDC FillObject(DataRow row)
        {
            VEHICLEDC objVEHICLE_VALU = null;
            objVEHICLE_VALU = new VEHICLEDC();
            objVEHICLE_VALU.VEHICLE_VALUE_ID = (int)row["VEHICLE_VALUE_ID"];
            objVEHICLE_VALU.VEHICLE_ID = (int)row["VEHICLE_ID"];
            objVEHICLE_VALU.DAILY_ID = (int)row["DAILY_ID"];
            objVEHICLE_VALU.NOTES = row["NOTES"] == DBNull.Value ? null : (String)row["NOTES"];
            objVEHICLE_VALU.HOURS = (Decimal)row["HOURS"];
            objVEHICLE_VALU.CREATED_ON = (DateTime)row["CREATED_ON"];
            objVEHICLE_VALU.CREATED_BY = (int)row["CREATED_BY"];
            objVEHICLE_VALU.MODIFIED_ON = (DateTime)row["MODIFIED_ON"];
            objVEHICLE_VALU.MODIFIED_BY = (int)row["MODIFIED_BY"];
            objVEHICLE_VALU.LOCK_COUNTER = (int)row["LOCK_COUNTER"];

            return objVEHICLE_VALU;
        }
    }
}
