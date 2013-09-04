using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.storage;
using System.Security.Cryptography.X509Certificates;
using SimpleJSON;
using AssemblyCSharp;

public class StorageTest : MonoBehaviour {
	ServiceAPI sp = null;
	StorageService storageService = null; // Initialising Storage Service.
	Constant cons = new Constant();
	
	public string collectionName = "NewCollection"; 
	public int max = 2;
	public int offSet = 1; 
	
	StorageResponse callBack = new StorageResponse();
	public string success, box;
	
	public static bool Validator(object sender, X509Certificate certificate, X509Chain chain,
                                      SslPolicyErrors sslPolicyErrors)
	    {
       	 return true;
        }
	
	// Use this for initialization
	void Start () {
		ServicePointManager.ServerCertificateValidationCallback = Validator;
		sp = new ServiceAPI(cons.apiKey,cons.secretKey);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
    {
		
		if (Time.time % 2 < 1) {
			success = callBack.getResult();
		}
        // For Setting Up ResponseBox.
		GUI.TextArea(new Rect(10,5,1300,175), success);
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(50, 200, 200, 30), "Insert JsonDoc"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					
					storageService.InsertJSONDocument(cons.dbName,collectionName,cons.json, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(260, 200, 200, 30), "Find AllDocuments"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindAllDocuments(cons.dbName,collectionName, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(470, 200, 200, 30), "Find AllCollections"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindAllCollections(cons.dbName, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(680, 200, 200, 30), "Find DocumentById"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindDocumentById(cons.dbName, collectionName,cons.docId, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(890, 200, 200, 30), "Find DocumentByKeyValue"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindDocumentByKeyValue(cons.dbName, collectionName, cons.key, cons.val, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(50, 250, 200, 30), "UpdateDocumentByKeyValue"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.UpdateDocumentByKeyValue(cons.dbName, collectionName,cons.key, cons.val, cons.newJson, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(260, 250, 200, 30), "UpdateDocumentById"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.UpdateDocumentByDocId(cons.dbName, collectionName, cons.docId, cons.newJson, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(470, 250, 200, 30), "Delete DocumentById"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					 storageService.DeleteDocumentById(cons.dbName, collectionName, cons.docId, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(680, 250, 200, 30), "Delete DocumentsByKeyValue"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.DeleteDocumentsByKeyValue(cons.dbName, collectionName, cons.key, cons.val, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(890, 250, 200, 30), "DeleteAllDocuments"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.DeleteAllDocuments(cons.dbName, collectionName, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(50, 300, 200, 30), "FindDocumentByKeyValue"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindDocumentByKeyValue(cons.dbName, collectionName, cons.key, cons.val, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(260, 300, 200, 30), "FindAllDocumentsCount"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindAllDocumentsCount(cons.dbName, collectionName, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(470, 300, 200, 30), "FindAllDocumentsByPaging"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
	            try
	            {
					storageService.FindAllDocuments(cons.dbName, collectionName, max, offSet, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(680, 300, 200, 30), "InsertJsonWithGeoTag"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
			
			    
	            try
	            {
					GeoTag gp = new GeoTag();
		            gp.SetLat(-73.99171);
		            gp.SetLng(40.738868);
		            storageService.SetGeoTag(gp);
		            storageService.InsertJSONDocument(cons.dbName, collectionName,
                    cons.json, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
		}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(890, 300, 200, 30), "FindDocumentsByLocation"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
			
			    try
	            {
				    GeoTag gp = new GeoTag();
		            gp.SetLat(-73.99171);
		            gp.SetLng(40.738868);
		            
				    GeoQuery query = QueryBuilder.BuildGeoQuery(gp, GeoOperator.NEAR, 100);
					storageService.FindDocumentsByLocation(cons.dbName, collectionName, query, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(50, 350, 200, 30), "FindAllDocumentsSelectKeys"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
			
			    try
	            {
				    
					HashSet<string> selectKeys = new HashSet<string>();
	                selectKeys.Add("Name");
	                storageService.SetSelectKeys(selectKeys);
					
					storageService.FindAllDocuments(cons.dbName, collectionName, callBack);
						
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
		
		//===================================**************=========================================
		 if (GUI.Button(new Rect(260, 350, 200, 30), "FindDocumentsByQuery"))
	        {
				storageService = sp.BuildStorageService(); // Initializing Storage Service.
			
			    try
	            {
				    
					Query q1 = QueryBuilder.Build("AppName", "de", Operator.LIKE);
		            Query q2 = QueryBuilder.Build("AppId", "123hg4bdb", Operator.LIKE);
		            Query q3 = QueryBuilder.CompoundOperator(q1, Operator.OR, q2);
					
					storageService.FindDocumentsByQuery(cons.dbName, collectionName, q3, callBack);
				}
				
	            catch (App42Exception e)
	            {
					success = "Exception Occurred :" + e.Message;
					App42Log.Console("Message : " + e.Message);	
				}
			}
}
}
