using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.buddy;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class BuddyResponse : App42CallBack
	{
		private string result = "";

		public void OnSuccess (object buddy)
		{
			Debug.Log ("BuddyName : " + buddy);
                    
			result = buddy.ToString ();
			try {
				if (buddy is Buddy) {
					Buddy buddyObj = (Buddy)buddy;
					result = buddyObj.ToString ();
					Debug.Log ("BuddyName : " + buddyObj.GetBuddyName ());
					Debug.Log ("GetMessage : " + buddyObj.GetMessage ());
					Debug.Log ("GetAcceptedOn : " + buddyObj.GetAcceptedOn ());
					Debug.Log ("GetMessageId : " + buddyObj.GetMessageId ());
					Debug.Log ("GetSendedOn : " + buddyObj.GetSendedOn ());
				} else {
					IList<Buddy> buddyList = (IList<Buddy>)buddy;
					result = buddyList [0].ToString ();
					for (int i = 0; i< buddyList.Count; i++) {
						Debug.Log ("BuddyName : " + buddyList [i].GetBuddyName ());
						Debug.Log ("GetMessage : " + buddyList [i].GetMessage ());
						Debug.Log ("GetAcceptedOn : " + buddyList [i].GetAcceptedOn ());
						Debug.Log ("GetMessageId : " + buddyList [i].GetMessageId ());
						Debug.Log ("GetSendedOn : " + buddyList [i].GetSendedOn ());
					}
				}
			} catch (App42Exception e) {
				result = e.ToString ();
				Debug.Log ("App42Exception : " + e);
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

