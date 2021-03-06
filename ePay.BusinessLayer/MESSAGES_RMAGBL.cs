
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 5/2/2015 5:37:59 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataClasses;
using EPay.DataAccess;

namespace EPay.BusinessLayer
{		
	public partial class MESSAGES_RMAGBL
	{
		public bool IsDirty { get; set; }
		
		public List<MESSAGES_RMAGDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			MESSAGES_RMAGDA objMESSAGES_RMAGDA = new MESSAGES_RMAGDA();
			List<MESSAGES_RMAGDC>  objMESSAGES_RMAGDC = null;
            try
            {
				objConnection.Open(false);
				objMESSAGES_RMAGDC = objMESSAGES_RMAGDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objMESSAGES_RMAGDC;
		}
		
		
		public MESSAGES_RMAGDC LoadByPrimaryKey(int MESSAGE_RMAG_ID)
		{
			DBConnection objConnection = new DBConnection();
			MESSAGES_RMAGDA objMESSAGES_RMAGDA = new MESSAGES_RMAGDA();
			MESSAGES_RMAGDC objMESSAGES_RMAGDC = null;
            try
            {
				objConnection.Open(false);
				objMESSAGES_RMAGDC = objMESSAGES_RMAGDA.LoadByPrimaryKey(objConnection, MESSAGE_RMAG_ID);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objMESSAGES_RMAGDC;
		}
		public int Update(List<MESSAGES_RMAGDC> objMESSAGES_RMAGs)        
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            MESSAGES_RMAGDA objMESSAGES_RMAGDA = new MESSAGES_RMAGDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objMESSAGES_RMAGDA.Update(objConnection, objMESSAGES_RMAGs);
                IsDirty = objMESSAGES_RMAGDA.IsDirty;
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
		public int Insert(List<MESSAGES_RMAGDC> objMESSAGES_RMAGs)        
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            MESSAGES_RMAGDA objMESSAGES_RMAGDA = new MESSAGES_RMAGDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objMESSAGES_RMAGDA.Insert(objConnection, objMESSAGES_RMAGs);
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
		public int Delete(List<MESSAGES_RMAGDC> objMESSAGES_RMAGs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            MESSAGES_RMAGDA objMESSAGES_RMAGDA = new MESSAGES_RMAGDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objMESSAGES_RMAGDA.Delete(objConnection, objMESSAGES_RMAGs);
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
