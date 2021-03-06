
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/6/2017 2:32:26 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataClasses;
using EPay.DataAccess;

namespace EPay.BusinessLayer
{		
	public class VEHICLEBL
	{
		public bool IsDirty { get; set; }
		
		public List<VEHICLEDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			VEHICLEDA objVEHICLE_VALUDA = new VEHICLEDA();
			List<VEHICLEDC>  objVEHICLE_VALUDC = null;
            try
            {
				objConnection.Open(false);
				objVEHICLE_VALUDC = objVEHICLE_VALUDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objVEHICLE_VALUDC;
		}
		
		
		public List<VEHICLEDC> LoadByDailyIDAndType(int DAILY_ID, int DAILY_TYPE)
        {
			DBConnection objConnection = new DBConnection();
			VEHICLEDA objVEHICLE_VALUDA = new VEHICLEDA();
            List<VEHICLEDC> objVEHICLE_VALUDC = null;
            try
            {
				objConnection.Open(false);
				objVEHICLE_VALUDC = objVEHICLE_VALUDA.LoadByDailyIDAndType(objConnection, DAILY_ID, DAILY_TYPE);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objVEHICLE_VALUDC;
		}
		public int Update(DBConnection objConnection, VEHICLEDC vehicleDC)        
        {
            int updatedCount = 0;
            VEHICLEDA objVEHICLE_VALUDA = new VEHICLEDA();
            updatedCount = objVEHICLE_VALUDA.Update(objConnection, vehicleDC);
            return updatedCount;
        }
		public int Insert(DBConnection objConnection, VEHICLEDC vehicleDC)        
        {
            int insertedCount = 0;
            VEHICLEDA objVEHICLE_VALUDA = new VEHICLEDA();
            insertedCount = objVEHICLE_VALUDA.Insert(objConnection, vehicleDC);
            return insertedCount;
        }
		public int Delete(List<VEHICLEDC> objVEHICLE_VALUs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            VEHICLEDA objVEHICLE_VALUDA = new VEHICLEDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objVEHICLE_VALUDA.Delete(objConnection, objVEHICLE_VALUs);
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
            return deletedCount;
        }	
		
		
	}
}
