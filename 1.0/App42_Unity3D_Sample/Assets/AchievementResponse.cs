using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.achievement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class AchievementResponse : App42CallBack
	{

		private string result = "";

		public void OnSuccess (object response)
		{
			if (response is Achievement) {
					Achievement achievement = (Achievement)response;
					Debug.Log ("userName  is : " + achievement.GetUserName());
					Debug.Log ("achievementName is : " + achievement.GetName());
					Debug.Log ("gameName is : " + achievement.GetGameName());
					Debug.Log ("AchievedOn is : " + achievement.GetAchievedOn());
					Debug.Log ("Description is : " + achievement.GetDescription ());
				}
				else { 
				IList<Achievement> achievementList = (IList<Achievement>)response;
				for (int i=0; i<achievementList.Count; i++) {
					Debug.Log ("userName  is : " + achievementList[i].GetUserName());
					Debug.Log ("achievementName is : " + achievementList[i].GetName());
					Debug.Log ("gameName is : " + achievementList[i].GetGameName());
					Debug.Log ("AchievedOn is : " + achievementList[i].GetAchievedOn());
					Debug.Log ("Description is : " + achievementList[i].GetDescription ());
				}
				
			}
		}
	
		public void OnException (Exception e)
		{
			result = e.ToString ();
			Debug.Log ("Exception : " + e);
		}
		
		public string GetResult()
		{
			return result;
		}	
	}
}
