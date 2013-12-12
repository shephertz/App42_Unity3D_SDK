using System;
using com.shephertz.app42.paas.sdk.csharp.pushNotification;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class PushNotificationResponse : App42CallBack
	{
		private string result = "";
		public void OnSuccess(object response)
        {
			result = response.ToString();
        	if(response is PushNotification){
				PushNotification pushNotification = (PushNotification)response;
				Debug.Log ("UserName : " + pushNotification.GetUserName());	
				Debug.Log ("Expiery : " + pushNotification.GetExpiry());
				Debug.Log ("DeviceToken : " + pushNotification.GetDeviceToken());	
				Debug.Log ("pushNotification : " + pushNotification.GetMessage());	
				Debug.Log ("pushNotification : " + pushNotification.GetStrResponse());	
				Debug.Log ("pushNotification : " + pushNotification.GetTotalRecords());	
				Debug.Log ("pushNotification : " + pushNotification.GetType());	
				Debug.Log ("pushNotification : " + pushNotification.GetChannelList());	
//				for(int i = 0 ; i < pushNotification.GetChannelList)
//				Debug.Log ("pushNotification : " + pushNotification.GetChannelList()[0].GetName());	
//				Debug.Log ("pushNotification : " + pushNotification.GetChannelList()[0].GetName());	
//				Debug.Log ("pushNotification : " + pushNotification.GetChannelList()[0].GetType());	
			}
		}
	
        public void OnException(Exception e)
        {
			result = e.ToString();
            Debug.Log ("Exception : " + e);
		}
		
		public string getResult() {
			return result;
		}	
	}
}

