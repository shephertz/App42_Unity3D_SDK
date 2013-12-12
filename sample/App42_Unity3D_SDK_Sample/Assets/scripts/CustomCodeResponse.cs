using System;
using com.shephertz.app42.paas.sdk.csharp.user;
using com.shephertz.app42.paas.sdk.csharp;
using System.Collections;
using SimpleJSON;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class CustomCodeResponse : App42CallBack
	{
		private string result = "";
		public void OnSuccess(object response)
        {
			if(response is JObject){
			JObject objecti = (JObject)response;
			App42Log.Console("objectName is : " + objecti["name"]);
			App42Log.Console("Success : " + response);
			}
		}
	
        public void OnException(Exception e)
        {
			result = e.ToString();
            App42Log.Console("Exception : " + e.ToString());
		}
		
		public string getResult() {
			return result;
		}	
	}
}

