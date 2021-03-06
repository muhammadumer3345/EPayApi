
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/20/2015 7:25:12 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using NMART.DataClasses;
using NMART.DataAccess;

namespace NMART.BusinessLayer
{		
	public partial class COMPANIES_RMAGBL
	{
		public bool IsDirty { get; set; }
		
		public List<COMPANIES_RMAGDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			COMPANIES_RMAGDA objCOMPANIES_RMAGDA = new COMPANIES_RMAGDA();
			List<COMPANIES_RMAGDC>  objCOMPANIES_RMAGDC = null;
            try
            {
				objConnection.Open(false);
				objCOMPANIES_RMAGDC = objCOMPANIES_RMAGDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objCOMPANIES_RMAGDC;
		}
		
		
		public COMPANIES_RMAGDC LoadByPrimaryKey(int COMPANY_RMAG_ID)
		{
			DBConnection objConnection = new DBConnection();
			COMPANIES_RMAGDA objCOMPANIES_RMAGDA = new COMPANIES_RMAGDA();
			COMPANIES_RMAGDC objCOMPANIES_RMAGDC = null;
            try
            {
				objConnection.Open(false);
				objCOMPANIES_RMAGDC = objCOMPANIES_RMAGDA.LoadByPrimaryKey(objConnection, COMPANY_RMAG_ID);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objCOMPANIES_RMAGDC;
		}
		public int Update(List<COMPANIES_RMAGDC> objCOMPANIES_RMAGs)        
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            COMPANIES_RMAGDA objCOMPANIES_RMAGDA = new COMPANIES_RMAGDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objCOMPANIES_RMAGDA.Update(objConnection, objCOMPANIES_RMAGs);
                IsDirty = objCOMPANIES_RMAGDA.IsDirty;
                if (IsDirty)
                    objConnection.Rollback();
                else
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
            return updatedCount;
        }
		public int Insert(List<COMPANIES_RMAGDC> objCOMPANIES_RMAGs)        
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            COMPANIES_RMAGDA objCOMPANIES_RMAGDA = new COMPANIES_RMAGDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objCOMPANIES_RMAGDA.Insert(objConnection, objCOMPANIES_RMAGs);
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
            return insertedCount;
        }
		public int Delete(List<COMPANIES_RMAGDC> objCOMPANIES_RMAGs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            COMPANIES_RMAGDA objCOMPANIES_RMAGDA = new COMPANIES_RMAGDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objCOMPANIES_RMAGDA.Delete(objConnection, objCOMPANIES_RMAGs);
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
