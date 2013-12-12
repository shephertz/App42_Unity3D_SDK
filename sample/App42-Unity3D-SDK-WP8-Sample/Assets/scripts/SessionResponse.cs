using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.session;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class SessionResponse : App42CallBack
	{

		private string result = "";

		public void OnSuccess (object session)
		{
			if (session is Session) {
				Session sessionObj = (Session)session;
				result = sessionObj.ToString ();
				Debug.Log ("UserName is : " + sessionObj.GetUserName ());
				Debug.Log ("SesionId is : " + sessionObj.GetSessionId ());
				Debug.Log ("TotalRecords is : " + sessionObj.GetTotalRecords ());
				Debug.Log ("InvalidateOn is : " + sessionObj.GetInvalidatedOn ());
				Debug.Log ("Response is : " + sessionObj.GetStrResponse ());
				Debug.Log ("AttributeList is : " + sessionObj.GetAttributeList ());
				if (sessionObj.GetAttributeList () != null) {
					IList<Session.Attribute> attributeList = sessionObj.GetAttributeList ();
					for (int i = 0; i<attributeList.Count; i++) {
						Debug.Log ("Name is : " + attributeList [i].GetName ());
						Debug.Log ("Type is : " + attributeList [i].GetType ());
						Debug.Log ("Value is : " + attributeList [i].GetValue ());
					}
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
