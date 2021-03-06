
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/6/2017 2:32:25 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataClasses;
using EPay.DataAccess;

namespace EPay.BusinessLayer
{		
	public class MAN_POWERBL
	{
		public bool IsDirty { get; set; }
		
		public List<MAN_POWERDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
			List<MAN_POWERDC>  objMAN_POWEDC = null;
            try
            {
				objConnection.Open(false);
				objMAN_POWEDC = objMAN_POWEDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objMAN_POWEDC;
		}
		
		
		public MAN_POWERDC LoadByPrimaryKey(int MAN_POWER_ID)
		{
			DBConnection objConnection = new DBConnection();
			MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
			MAN_POWERDC objMAN_POWEDC = null;
            try
            {
				objConnection.Open(false);
				objMAN_POWEDC = objMAN_POWEDA.LoadByPrimaryKey(objConnection, MAN_POWER_ID);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objMAN_POWEDC;
		}

        public List<String> LoadNames(string Column_Name, string Column_Value)
        {
            DBConnection objConnection = new DBConnection();
            MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
            List<String> names = new List<string>();
            try
            {
                objConnection.Open(false);
                names = objMAN_POWEDA.LoadNames(objConnection, Column_Name, Column_Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return names;

        }

        public List<MAN_POWERDC> LoadByDailyID(int DAILY_ID)
        {
            DBConnection objConnection = new DBConnection();
            MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
            List<MAN_POWERDC> objMAN_POWEDC = new List<MAN_POWERDC>();
            try
            {
                objConnection.Open(false);
                objMAN_POWEDC = objMAN_POWEDA.LoadByDailyID(objConnection, DAILY_ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return objMAN_POWEDC;
        }
        public int Update(DBConnection objConnection, MAN_POWERDC objMAN_POWEs)        
        {
            int updatedCount = 0;
            MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
            updatedCount = objMAN_POWEDA.Update(objConnection, objMAN_POWEs);
            return updatedCount;
        }
		public int Insert(DBConnection objConnection, MAN_POWERDC objMAN_POWEs)        
        {
            int insertedCount = 0;
            MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
            insertedCount = objMAN_POWEDA.Insert(objConnection, objMAN_POWEs);
            return insertedCount;
        }
		public int Delete(List<MAN_POWERDC> objMAN_POWEs)        
        {
            int updatedLockCounter = 0;
            DBConnection objConnection = new DBConnection();
            MAN_POWERDA objMAN_POWEDA = new MAN_POWERDA();
            try
            {
                objConnection.Open(true);
                updatedLockCounter = objMAN_POWEDA.Delete(objConnection, objMAN_POWEs);
                objConnection.Commit();
            }
            catch (Exception ex)
            {
                objConnection.Rollback();
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return updatedLockCounter;
        }	
		
		
	}
}
