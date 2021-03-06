
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 5/13/2015 3:42:18 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataClasses;
using EPay.DataAccess;

namespace EPay.BusinessLayer
{		
	public class NOTIFICATIONBL
	{
		public bool IsDirty { get; set; }
		
		public List<NOTIFICATIONDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			NOTIFICATIONDA objNOTIFICATIONDA = new NOTIFICATIONDA();
			List<NOTIFICATIONDC>  objNOTIFICATIONDC = null;
            try
            {
				objConnection.Open(false);
				objNOTIFICATIONDC = objNOTIFICATIONDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objNOTIFICATIONDC;
		}


  //      public List<NOTIFICATIONDC> LoadAllByEventAndType(int EventId, int TypeId, int UserId, int NoOfPages)
		//{
		//	DBConnection objConnection = new DBConnection();
		//	NOTIFICATIONDA objNOTIFICATIONDA = new NOTIFICATIONDA();
  //          List<NOTIFICATIONDC> objNOTIFICATIONDC = null;
  //          try
  //          {
		//		objConnection.Open(false);
  //              objNOTIFICATIONDC = objNOTIFICATIONDA.LoadAllByEventAndType(objConnection, EventId, TypeId, UserId,NoOfPages);                
  //          }
  //          catch (Exception ex)
  //          {
  //              throw ex;
  //          }   
		//	finally 
  //          {
  //              objConnection.Close();
  //          }
  //          return objNOTIFICATIONDC;
		//}
		public int Update(List<NOTIFICATIONDC> objNOTIFICATIONs)        
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            NOTIFICATIONDA objNOTIFICATIONDA = new NOTIFICATIONDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objNOTIFICATIONDA.Update(objConnection, objNOTIFICATIONs);
                IsDirty = objNOTIFICATIONDA.IsDirty;
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
		public int Insert(List<NOTIFICATIONDC> objNOTIFICATIONs)        
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            NOTIFICATIONDA objNOTIFICATIONDA = new NOTIFICATIONDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objNOTIFICATIONDA.Insert(objConnection, objNOTIFICATIONs);
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
		public int Delete(List<NOTIFICATIONDC> objNOTIFICATIONs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            NOTIFICATIONDA objNOTIFICATIONDA = new NOTIFICATIONDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objNOTIFICATIONDA.Delete(objConnection, objNOTIFICATIONs);
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
