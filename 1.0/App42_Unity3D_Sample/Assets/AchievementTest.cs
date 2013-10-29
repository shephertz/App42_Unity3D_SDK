	using UnityEngine;
	using UnityEngine.SocialPlatforms;
	using System.Collections;
	using System.Collections.Generic;
	using System.Net;
	using System;
	using System.Net.Security;
	using com.shephertz.app42.paas.sdk.csharp;
	using com.shephertz.app42.paas.sdk.csharp.achievement;
	using System.Security.Cryptography.X509Certificates;
	using AssemblyCSharp;
	
public class AchievementTest : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	AchievementService achievementService = null; // Initializing Achievement Service.
	public string success;
	AchievementResponse callBack = new AchievementResponse();

	public static bool Validator (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	void Start ()
	{
		ServicePointManager.ServerCertificateValidationCallback = Validator;
		sp = new ServiceAPI (cons.apiKey,cons.secretKey);
	}
		
	// Update is called once per frame
	void Update ()
	{	
	}
		
	void OnGUI ()
	{
			
		if (Time.time % 2 < 1) {
			success = callBack.GetResult ();
		}
	      
		// For Setting Up ResponseBox.
		GUI.TextArea (new Rect (10, 5, 1300, 175), success);
			 
	
		//======================================= Achievement Service======================================
			 
		if (GUI.Button (new Rect (50, 200, 200, 30), "Create Achievement")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService(); // Initializing Achievement Service.
			achievementService.CreateAchievement (cons.achievementName, cons.description, callBack);
		}
			
		//==================================== Achievement Service=========================================
			 
		if (GUI.Button (new Rect (260, 200, 200, 30), "Earn Achievement")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.EarnAchievement (cons.userName, cons.achievementName, cons.gameName, cons.description, callBack);
		}
			
		//==================================== Achievement Service========================================
			 
		if (GUI.Button (new Rect (470, 200, 200, 30), "GetAll Achievements ForUser")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.GetAllAchievementsForUser(cons.userName, callBack);
		}
			
		//===================================== Achievement Service=======================================	
			 
		if (GUI.Button (new Rect (680, 200, 200, 30), "GetAll Achievements ForUserInGame")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.GetAllAchievementsForUserInGame (cons.userName, cons.gameName, callBack);
		}
			
		//====================================== Achievement Service======================================	
			 
		if (GUI.Button (new Rect (890, 200, 200, 30), "GetAll Achievements")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.GetAllAchievements (callBack);
		}
			
		//====================================== Achievement Service======================================	
			 
		if (GUI.Button (new Rect (50, 250, 200, 30), "Get Achievement ByName")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.GetAchievementByName (cons.achievementName, callBack);
		}
			
		//======================================= Achievement Service=====================================	
			 
		if (GUI.Button (new Rect (260, 250, 200, 30), "GetUsers Achievement")) {
			App42Log.SetDebug(true);
			achievementService = sp.BuildAchievementService (); // Initializing Achievement Service.
			achievementService.GetUsersAchievement(cons.achievementName, cons.gameName, callBack);
		}
	}
}