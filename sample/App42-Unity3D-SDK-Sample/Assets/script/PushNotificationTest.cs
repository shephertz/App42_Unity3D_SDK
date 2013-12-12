using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.pushNotification;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class PushNotificationTest : MonoBehaviour
{
	//=====================================================================================================
	Constant cons = new Constant ();                                    // Making cons Object For Using Constant.
	PushNotificationResponse callBack = new PushNotificationResponse();// Making callBack Object for PushNotificationResponse.
    ServiceAPI sp = null;                                             // Initializing Service API.
	PushNotificationService pushNotificationService = null;          // Initializing PushNotification Service.
	//=====================================================================================================
	
	//=======================================================================================
	public string password = "password";
	public int max = 2;
	public int offSet = 1;
	public string success, box;
	//=======================================================================================
	
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
		 
		//=========================================================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "Create Channel ForApp")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.CreateChannelForApp (cons.channelName, cons.description, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "Store Device Token")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.StoreDeviceToken (cons.userName, cons.deviceToken, "<Enter_your-device_type>", callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "Subscribe To Channel ")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SubscribeToChannel (cons.channelName, cons.userName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "Send Push Message ToChannel ")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SendPushMessageToChannel (cons.channelName, cons.message, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "SendPush Message To User")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SendPushMessageToUser (cons.userName, cons.message, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "Send PushMessage ToAll")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SendPushMessageToAll (cons.message, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "Send PushMessage ToAll ByType")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SendPushMessageToAllByType (cons.message, "<Enter_your-device_type>", callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "Unsubscribe Device To Channel")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.UnsubscribeDeviceToChannel (cons.userName, cons.channelName, cons.deviceToken, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "Unsubscribe From Channel")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.UnsubscribeFromChannel (cons.channelName, cons.userName, callBack);
		}	
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (890, 250, 240, 30), "Subscribe Channel With DeviceToken")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.SubscribeToChannel (cons.userName, cons.channelName, cons.deviceToken,"<Enter_your-device_type>", callBack);
		}
		//===================================###################=========================================	
		if (GUI.Button (new Rect (50, 300, 200, 30), "Delete Device Token")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			pushNotificationService.DeleteDeviceToken(cons.userName, cons.deviceToken, callBack);
		}	
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (260, 300, 240, 30), "Send PushMessage ToGroup")) {
			pushNotificationService = sp.BuildPushNotificationService (); // Initializing PushNotification Service.
			IList<String> userList = new List<String>();
			userList.Add(cons.userName);
			userList.Add(cons.userName1);
			pushNotificationService.SendPushMessageToGroup(cons.message, userList, callBack);
		}
	}
}