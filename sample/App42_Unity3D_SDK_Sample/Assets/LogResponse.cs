using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.log;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class LogResponse : App42CallBack
	{
		private string result = "";

		public void OnSuccess (object log)
		{
			if (log is Log) {
				Log logObj = (Log)log;
				result = logObj.ToString();
            	App42Log.Console("Log Obj is : " + logObj);  
				IList<Log.Message> messageList = logObj.GetMessageList();
				for(int i = 0; i < messageList.Count; i++){
	            	App42Log.Console("Module is   : " + messageList[i].GetModule());
	            	App42Log.Console("LogTime is  : " + messageList[i].GetLogTime());
	            	App42Log.Console("Type is  :  " + messageList[i].GetType());
	            	App42Log.Console("Message is :  " + messageList[i].GetMessage());
				}
			}
		}
	
		public void OnException (Exception e)
		{
			result = e.ToString ();
			App42Log.Console("Exception : " + e);
		}
		
		public string getResult ()
		{
			return result;
		}	
	}
}

