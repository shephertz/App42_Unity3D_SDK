using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.log;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class LogTest : MonoBehaviour
{
	//==========================================================
	Constant cons = new Constant ();
	LogResponse callBack = new LogResponse ();
	ServiceAPI sp = null;
	LogService logService = null; // Initializing Log Service.
	//==========================================================
	
	//==========================================================
	public string userName = "Aks" + DateTime.Now.Ticks;
	public string module = "LogModule";
	public string eventName = "LogEvent";
	public string text = "LogTEXT";
	public string level = "LogLEVEL";
	public string msg = "Hi I M Using App42 Log For Unity3D";
	public DateTime startDate = DateTime.Now;
	public DateTime endDate = DateTime.Now;
	public int max = 2;
	public int offSet = 1;
	public string success;
	//==========================================================
	
	
	
	public static bool Validator (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}
	
	// Use this for initialization
	void Start ()
	{
		ServicePointManager.ServerCertificateValidationCallback = Validator;
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
		GUI.TextArea (new Rect (10, 5, 1300, 175), success);
		 

		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 200, 200, 30), "Info")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.Info (msg, module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 200, 200, 30), "Debug")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.Debug (msg, module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 200, 200, 30), "Fatal")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.Fatal (msg, module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 200, 200, 30), "Error")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.Error (msg, module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (890, 200, 200, 30), "FetchLogsByModule")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByModule (module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 250, 200, 30), "FetchLogsByModuleAndText")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByModuleAndText (module, text, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 250, 200, 30), "SetEvent")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.SetEvent (eventName, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 250, 200, 30), "FetchLogsByInfo")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByInfo (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 250, 200, 30), "FetchLogsByDebug")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByDebug (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (890, 250, 200, 30), "FetchLogsByError")) {
			App42Log.SetDebug(true);
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByError (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 300, 200, 30), "FetchLogsByFatal")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByFatal (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 300, 200, 30), "FetchLogByDateRange")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogByDateRange (startDate, endDate, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 300, 200, 30), "FetchLogsByInfoByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByInfo (max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 300, 200, 30), "FetchLogsByDebugByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByDebug (max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (890, 300, 200, 30), "FetchLogsByErrorByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByError (max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 350, 200, 30), "FetchLogsByFatalByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByFatal (max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 350, 200, 30), "FetchLogsByModuleByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByModule (module, max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 350, 200, 30), "FetchLogsByModuleAndTextByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsByModuleAndText (module, text, max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 350, 200, 30), "FetchLogByDateRangeByPaging")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogByDateRange (startDate, endDate, max, offSet, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (890, 350, 200, 30), "FetchLogsCountByModule")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByModule (module, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 400, 200, 30), "FetchLogsCountByModuleAndText")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByModuleAndText (module, text, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 400, 200, 30), "FetchLogsCountByInfo")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByInfo (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 400, 200, 30), "FetchLogsCountByDebug")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByDebug (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 400, 200, 30), "FetchLogsCountByError")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByError (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (890, 400, 200, 30), "FetchLogsCountByFatal")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogsCountByFatal (callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 450, 200, 30), "FetchLogCountByDateRange")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.FetchLogCountByDateRange (startDate, endDate, callBack);
		}
		
		//=======================================LOG_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 450, 200, 30), "SetEvent")) {
			logService = sp.BuildLogService (); // Initializing Log Service.
			logService.SetEvent (module, eventName, callBack);
		}
	}
}

