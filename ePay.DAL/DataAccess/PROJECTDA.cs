
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 1/11/2017 5:45:00 PM
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
    public partial class PROJECTDA
    {
        public bool ISDIRTY { get; set; }

        //=================================================================
        //  	public Function LoadAll() As Boolean
        //=================================================================
        //  Loads all of the records in the database, and sets the currentRow to the first row
        //=================================================================
        public List<PROJECTDC> LoadAll(DBConnection Connection, string clientIDs = "All", string projectStatusIDs = "All")
        {
            List<PROJECTDC> objPROJECT = new List<PROJECTDC>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSLoadAll");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_clientIDs", DbType.String, clientIDs);
            dbCommandWrapper.AddInParameter("p_projectStatusIDs", DbType.String, projectStatusIDs);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            foreach (DataRow drRow in ds.Tables[0].Rows)
            {
                objPROJECT.Add(FillObject(drRow));
            }

            return objPROJECT;
        }

        public List<PROJECTDC> LoadAllByStatus(DBConnection Connection, String projectStatus)
        {
            List<PROJECTDC> objPROJECT = new List<PROJECTDC>();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSLoadAllByStatus");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_PROJECT_STATUS", DbType.String, projectStatus);

            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            foreach (DataRow drRow in ds.Tables[0].Rows)
            {
                objPROJECT.Add(FillObject(drRow));
            }

            return objPROJECT;
        }

        public PROJECTDC LoadByPrimaryKey(DBConnection Connection, int PROJECT_ID)
        {
            PROJECTDC objPROJECT = new PROJECTDC();
            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSLoadByPrimaryKey");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);
            dbCommandWrapper.AddInParameter("p_PROJECT_ID", DbType.Int32, PROJECT_ID);


            DataSet ds = new DataSet();

            if (Connection.Transaction != null)
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                ds = Connection.dataBase.ExecuteDataSet(dbCommandWrapper.DBCommand);

            if(ds.Tables[0].Rows.Count > 0)
                objPROJECT = FillObject(ds.Tables[0].Rows[0]);
            return objPROJECT;
        }
       
        public int Update(DBConnection Connection, PROJECTDC objPROJECT)
        {
            int updateCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSUpdate");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);


            dbCommandWrapper.AddInParameter("p_PROJECT_ID", DbType.Int32, objPROJECT.PROJECT_ID);
            dbCommandWrapper.AddInParameter("p_HYLAN_PROJECT_ID", DbType.String, objPROJECT.HYLAN_PROJECT_ID);
            dbCommandWrapper.AddInParameter("p_HYLAN_JOB_NUMBER", DbType.String, objPROJECT.HYLAN_JOB_NUMBER);
            dbCommandWrapper.AddInParameter("p_PROJECT_BID_NAME", DbType.String, objPROJECT.PROJECT_BID_NAME);
            dbCommandWrapper.AddInParameter("p_CLIENT", DbType.String, objPROJECT.CLIENT);
            dbCommandWrapper.AddInParameter("p_PROJECT_STATUS", DbType.Int16, objPROJECT.PROJECT_STATUS);
            dbCommandWrapper.AddInParameter("p_TENTATIVE_PROJECT_START_DATE", DbType.DateTime, objPROJECT.TENTATIVE_PROJECT_START_DATE);
            dbCommandWrapper.AddInParameter("p_ACTUAL_PROJECT_START_DATE", DbType.DateTime, objPROJECT.ACTUAL_PROJECT_START_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECTED_END_DATE", DbType.DateTime, objPROJECT.PROJECTED_END_DATE);
            dbCommandWrapper.AddInParameter("p_ACTUAL_PROJECT_CLOSE_DATE", DbType.DateTime, objPROJECT.ACTUAL_PROJECT_CLOSE_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECT_BID_DATE", DbType.DateTime, objPROJECT.PROJECT_BID_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECT_AWARDED", DbType.DateTime, objPROJECT.PROJECT_AWARDED);
            dbCommandWrapper.AddInParameter("p_BID_DOCUMENTS", DbType.String, objPROJECT.BID_DOCUMENTS);
            dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objPROJECT.NOTES);
            dbCommandWrapper.AddInParameter("p_PO_NUMBER", DbType.String, objPROJECT.PO_NUMBER);
            dbCommandWrapper.AddInParameter("p_PO_AMOUNT", DbType.Decimal, objPROJECT.PO_AMOUNT);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objPROJECT.CREATED_ON);
            dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objPROJECT.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objPROJECT.MODIFIED_ON);
            dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objPROJECT.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objPROJECT.LOCK_COUNTER);

            try
            {
                if (Connection.Transaction != null)
                    updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
                else
                    updateCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

                if (updateCount == 0)
                {
                    objPROJECT.ISDIRTY = ISDIRTY = true;
                    throw new Exception(Constants.ConcurrencyMessageSingleRow);
                }
            }
            catch (Exception exp)
            {
                //Utilities.InsertIntoErrorLog("Error: PROJECT UPDATE ", exp.Message + "\r\n" + exp.StackTrace, Convert.ToInt32(objPROJECT.MODIFIED_BY));
                objPROJECT.SetError(exp);
                throw exp;
            }
            return updateCount;
        }
        public int Insert(DBConnection Connection, List<PROJECTDC> objPROJECTs)
        {
            int insertCount = 0;
            foreach (PROJECTDC objPROJECT in objPROJECTs)
            {
                insertCount = Insert(Connection, objPROJECT);
            }
            return insertCount;
        }

        public int Insert(DBConnection Connection, PROJECTDC objPROJECT)
        {
            int p_ID = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSInsert");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);

            dbCommandWrapper.AddOutParameter("p_PROJECT_ID", DbType.Int32, objPROJECT.PROJECT_ID);
            dbCommandWrapper.AddInParameter("p_HYLAN_PROJECT_ID", DbType.String, objPROJECT.HYLAN_PROJECT_ID);
            dbCommandWrapper.AddInParameter("p_HYLAN_JOB_NUMBER", DbType.String, objPROJECT.HYLAN_JOB_NUMBER);
            dbCommandWrapper.AddInParameter("p_PROJECT_BID_NAME", DbType.String, objPROJECT.PROJECT_BID_NAME);
            dbCommandWrapper.AddInParameter("p_CLIENT", DbType.String, objPROJECT.CLIENT);
            dbCommandWrapper.AddInParameter("p_PROJECT_STATUS", DbType.Int16, objPROJECT.PROJECT_STATUS);
            dbCommandWrapper.AddInParameter("p_TENTATIVE_PROJECT_START_DATE", DbType.DateTime, objPROJECT.TENTATIVE_PROJECT_START_DATE);
            dbCommandWrapper.AddInParameter("p_ACTUAL_PROJECT_START_DATE", DbType.DateTime, objPROJECT.ACTUAL_PROJECT_START_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECTED_END_DATE", DbType.DateTime, objPROJECT.PROJECTED_END_DATE);
            dbCommandWrapper.AddInParameter("p_ACTUAL_PROJECT_CLOSE_DATE", DbType.DateTime, objPROJECT.ACTUAL_PROJECT_CLOSE_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECT_BID_DATE", DbType.DateTime, objPROJECT.PROJECT_BID_DATE);
            dbCommandWrapper.AddInParameter("p_PROJECT_AWARDED", DbType.DateTime, objPROJECT.PROJECT_AWARDED);
            dbCommandWrapper.AddInParameter("p_BID_DOCUMENTS", DbType.String, objPROJECT.BID_DOCUMENTS);
            dbCommandWrapper.AddInParameter("p_NOTES", DbType.String, objPROJECT.NOTES);
            dbCommandWrapper.AddInParameter("p_PO_NUMBER", DbType.String, objPROJECT.PO_NUMBER);
            dbCommandWrapper.AddInParameter("p_PO_AMOUNT", DbType.Decimal, objPROJECT.PO_AMOUNT);
            dbCommandWrapper.AddInParameter("p_CREATED_ON", DbType.DateTime, objPROJECT.CREATED_ON);
            dbCommandWrapper.AddInParameter("p_CREATED_BY", DbType.Int32, objPROJECT.CREATED_BY);
            dbCommandWrapper.AddInParameter("p_MODIFIED_ON", DbType.DateTime, objPROJECT.MODIFIED_ON);
            dbCommandWrapper.AddInParameter("p_MODIFIED_BY", DbType.Int32, objPROJECT.MODIFIED_BY);
            dbCommandWrapper.AddInParameter("p_LOCK_COUNTER", DbType.Int32, objPROJECT.LOCK_COUNTER);


            if (Connection.Transaction != null)
                Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            p_ID = Convert.ToInt32(dbCommandWrapper.DBCommand.Parameters["@p_PROJECT_ID"].Value);
            return p_ID;
        }
        public int Delete(DBConnection Connection, List<PROJECTDC> objPROJECTs)
        {
            int deleteCount = 0;
            foreach (PROJECTDC objPROJECT in objPROJECTs)
            {
                deleteCount = Delete(Connection, objPROJECT);
            }
            return deleteCount;
        }
        private int Delete(DBConnection Connection, PROJECTDC objPROJECT)
        {
            int deleteCount = 0;

            StringBuilder sql = new StringBuilder();
            sql.Append("proc_PROJECTSDelete");

            DBCommandWarpper dbCommandWrapper = new DBCommandWarpper(Connection.dataBase.GetStoredProcCommand(sql.ToString()), Connection);

            dbCommandWrapper.AddInParameter("p_ID", DbType.Int32, objPROJECT.PROJECT_ID);

            if (Connection.Transaction != null)
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand, Connection.Transaction);
            else
                deleteCount = Connection.dataBase.ExecuteNonQuery(dbCommandWrapper.DBCommand);

            return deleteCount;
        }
        
        ///*
       
        //*/
    }
}
