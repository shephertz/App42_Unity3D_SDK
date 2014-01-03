using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.storage;
using SimpleJSON;
using AssemblyCSharp;

public class StorageTest : MonoBehaviour
{
		ServiceAPI sp = null;
		StorageService storageService = null; // Initialising Storage Service.
		Constant cons = new Constant ();
		public string collectionName = "NewCollection";
		public int max = 2;
		public int offSet = 1;
		StorageResponse callBack = new StorageResponse ();
		public string success, box;
	
	#if UNITY_EDITOR
	public static bool Validator (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
	{return true;}
	#endif
		void Start ()
		{
				#if UNITY_EDITOR
		ServicePointManager.ServerCertificateValidationCallback = Validator;
				#endif
				sp = new ServiceAPI (cons.apiKey, cons.secretKey);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnGUI ()
		{
				if (Time.time % 2 < 1) {
						success = callBack.getResult ();
				}
				// For Setting Up ResponseBox.
				GUI.TextArea (new Rect (10, 5, 1000, 175), success);
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (50, 200, 200, 30), "Insert JsonDoc")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.InsertJSONDocument (cons.dbName, collectionName, cons.json, callBack);
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (260, 200, 200, 30), "Find AllDocuments")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindAllDocuments (cons.dbName, collectionName, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (470, 200, 200, 30), "Find AllCollections")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindAllCollections (cons.dbName, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (680, 200, 200, 30), "Find DocumentById")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindDocumentById (cons.dbName, collectionName, cons.docId, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (890, 200, 200, 30), "Find DocumentByKeyValue")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindDocumentByKeyValue (cons.dbName, collectionName, cons.key, cons.val, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (50, 250, 200, 30), "UpdateDocumentByKeyValue")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.UpdateDocumentByKeyValue (cons.dbName, collectionName, cons.key, cons.val, cons.newJson, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (260, 250, 200, 30), "UpdateDocumentById")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.UpdateDocumentByDocId (cons.dbName, collectionName, cons.docId, cons.newJson, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (470, 250, 200, 30), "Delete DocumentById")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.DeleteDocumentById (cons.dbName, collectionName, cons.docId, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (680, 250, 200, 30), "Delete DocumentsByKeyValue")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.DeleteDocumentsByKeyValue (cons.dbName, collectionName, cons.key, cons.val, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (890, 250, 200, 30), "DeleteAllDocuments")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.DeleteAllDocuments (cons.dbName, collectionName, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (50, 300, 200, 30), "FindDocumentByKeyValue")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindDocumentByKeyValue (cons.dbName, collectionName, cons.key, cons.val, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (260, 300, 200, 30), "FindAllDocumentsCount")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindAllDocumentsCount (cons.dbName, collectionName, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (470, 300, 200, 30), "FindAllDocumentsByPaging")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.FindAllDocuments (cons.dbName, collectionName, max, offSet, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (680, 300, 200, 30), "InsertJsonWithGeoTag")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
			
			    
						GeoTag gp = new GeoTag ();
						gp.SetLat (-73.99171);
						gp.SetLng (40.738868);
						storageService.SetGeoTag (gp);
						storageService.InsertJSONDocument (cons.dbName, collectionName,
                    cons.json, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (890, 300, 200, 30), "FindDocumentsByLocation")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
			
						GeoTag gp = new GeoTag ();
						gp.SetLat (-73.99171);
						gp.SetLng (40.738868);
		            
						GeoQuery query = QueryBuilder.BuildGeoQuery (gp, GeoOperator.NEAR, 100);
						storageService.FindDocumentsByLocation (cons.dbName, collectionName, query, callBack);
				
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (50, 350, 200, 30), "FindAllDocumentsSelectKeys")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
			    
						HashSet<string> selectKeys = new HashSet<string> ();
						selectKeys.Add ("Name");
						storageService.SetSelectKeys (selectKeys);
						storageService.FindAllDocuments (cons.dbName, collectionName, callBack);
				}
		
				//===================================**************=========================================
				if (GUI.Button (new Rect (260, 350, 200, 30), "FindDocumentsByQuery")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						Query q1 = QueryBuilder.Build ("AppName", "de", Operator.LIKE);
						Query q2 = QueryBuilder.Build ("AppId", "123hg4bdb", Operator.LIKE);
						Query q3 = QueryBuilder.CompoundOperator (q1, Operator.OR, q2);
						storageService.FindDocumentsByQuery (cons.dbName, collectionName, q3, callBack);
				}if (GUI.Button (new Rect (470, 350, 200, 30), "SaveOrUpdateDocument")) {
						storageService = sp.BuildStorageService (); // Initializing Storage Service.
						storageService.SaveOrUpdateDocumentByKeyValue(cons.dbName, collectionName, cons.key,cons.val,cons.newJson, callBack);
				}
		}
}
