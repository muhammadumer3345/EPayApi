
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 2/23/2017 2:54:15 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataAccess;
using NMART.DataClasses;
using NMART.DataAccess;

namespace NMART.BusinessLayer
{		
	public class PROJECT_ATTACHMENTBL
	{
		public bool IsDirty { get; set; }
		
		public List<PROJECT_ATTACHMENTDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			PROJECT_ATTACHMENTDA objPROJECT_ATTACHMENTDA = new PROJECT_ATTACHMENTDA();
			List<PROJECT_ATTACHMENTDC>  objPROJECT_ATTACHMENTDC = null;
            try
            {
				objConnection.Open(false);
				objPROJECT_ATTACHMENTDC = objPROJECT_ATTACHMENTDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objPROJECT_ATTACHMENTDC;
		}
		
		
		public PROJECT_ATTACHMENTDC LoadByPrimaryKey(int PROJECT_ID, int ATTACHMENT_ID)
		{
			DBConnection objConnection = new DBConnection();
			PROJECT_ATTACHMENTDA objPROJECT_ATTACHMENTDA = new PROJECT_ATTACHMENTDA();
			PROJECT_ATTACHMENTDC objPROJECT_ATTACHMENTDC = null;
            try
            {
				objConnection.Open(false);
				objPROJECT_ATTACHMENTDC = objPROJECT_ATTACHMENTDA.LoadByPrimaryKey(objConnection, PROJECT_ID, ATTACHMENT_ID);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objPROJECT_ATTACHMENTDC;
		}
		public int Update(List<PROJECT_ATTACHMENTDC> objPROJECT_ATTACHMENTs)        
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            PROJECT_ATTACHMENTDA objPROJECT_ATTACHMENTDA = new PROJECT_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objPROJECT_ATTACHMENTDA.Update(objConnection, objPROJECT_ATTACHMENTs);
                IsDirty = objPROJECT_ATTACHMENTDA.IsDirty;
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
		public int Insert(List<PROJECT_ATTACHMENTDC> objPROJECT_ATTACHMENTs)        
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            PROJECT_ATTACHMENTDA objPROJECT_ATTACHMENTDA = new PROJECT_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objPROJECT_ATTACHMENTDA.Insert(objConnection, objPROJECT_ATTACHMENTs);
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
		public int Delete(List<PROJECT_ATTACHMENTDC> objPROJECT_ATTACHMENTs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            PROJECT_ATTACHMENTDA objPROJECT_ATTACHMENTDA = new PROJECT_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objPROJECT_ATTACHMENTDA.Delete(objConnection, objPROJECT_ATTACHMENTs);
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
