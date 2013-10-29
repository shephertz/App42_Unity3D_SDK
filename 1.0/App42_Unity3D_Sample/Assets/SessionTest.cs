using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.session;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class SessionTest : MonoBehaviour {
    Constant cons = new Constant();
	ServiceAPI sp = null;
	SessionService sessionService = null; // Initializing User Service.
	
	public string sessionId = "";
	
	public string success;
	
	SessionResponse callBack = new SessionResponse();
	public static bool Validator(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
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
		 

		//=======================================SESSION_SERVICE=======================================
		 
		if (GUI.Button(new Rect(50, 200, 200, 30), "GetSession"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.GetSession(cons.userName,callBack);
			}
		
		//====================================SESSION_SERVICE==========================================
		 
		if (GUI.Button(new Rect(260, 200, 200, 30), "GetSessionIsCreate"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.GetSession(cons.userName, cons.isCreate, callBack);
			}
		
		//====================================SESSION_SERVICE=========================================
		 
		if (GUI.Button(new Rect(470, 200, 200, 30), "Invalidate"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.Invalidate(cons.sessionId, callBack);
			}
		
		//=====================================SESSION_SERVICE========================================	
		 
		if (GUI.Button(new Rect(680, 200, 200, 30), "SetAttribute"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.SetAttribute(cons.sessionId,cons.attributeName,cons.attributeValue, callBack);
			}
		
		//======================================SESSION_SERVICE=======================================	
		 
		if (GUI.Button(new Rect(890, 200, 200, 30), "GetAttribute"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.GetAttribute(cons.sessionId,cons.attributeName, callBack);
			}
		
		//======================================SESSION_SERVICE=======================================	
		 
		if (GUI.Button(new Rect(50, 250, 200, 30), "GetAllAttributes"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.GetAllAttributes(cons.sessionId, callBack);
			}
		
		//=======================================SESSION_SERVICE======================================	
		 
		if (GUI.Button(new Rect(260, 250, 200, 30), "RemoveAttribute"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.RemoveAttribute(cons.sessionId,cons.attributeName, callBack);
			}
		
		//========================================SESSION_SERVICE=====================================	
		 
		if (GUI.Button(new Rect(470, 250, 200, 30), "RemoveAllAttributes"))
	        {
				sessionService = sp.BuildSessionService(); // Initializing Session Service.
				sessionService.RemoveAllAttributes(cons.sessionId, callBack);
			}
	}
}