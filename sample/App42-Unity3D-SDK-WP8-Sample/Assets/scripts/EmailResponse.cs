using System;
using UnityEngine;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.email;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class EmailResponse : App42CallBack
	{
		private string result = "";

		public void OnSuccess (object email)
		{
			if (email is Email) {
				Email emailObj = (Email)email;
				result = emailObj.ToString ();
				Debug.Log ("GetBody:  "+ emailObj.GetBody());
				Debug.Log ("GetFrom : "+ emailObj.GetFrom());
				Debug.Log ("GetTo :  "+ emailObj.GetTo());
				Debug.Log ("GetConfigList : "+ emailObj.GetConfigList());
				for(int i = 0; i < emailObj.GetConfigList().Count;i++){
					Debug.Log ("EmailId is :  " + emailObj.GetConfigList()[i].GetEmailId());
					Debug.Log ("GetHost :  " + emailObj.GetConfigList()[i].GetHost());
					Debug.Log ("GetPort :  " + emailObj.GetConfigList()[i].GetPort());
				}
			}
		}

		public void OnException (Exception e)
		{
			result = e.ToString ();
			Debug.Log ("Exception : " + e);
		}
		
		public string getResult ()
		{
			return result;
		}	
	}
}

