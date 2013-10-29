using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using AssemblyCSharp;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.reward;
using System.Security.Cryptography.X509Certificates;

public class RewardTest : MonoBehaviour
{
	ServiceAPI sp = null;
	RewardService rewardService = null; // Initialising Reward Service.
	Constant cons = new Constant ();
	public string rewardDescription = "REWARD DESCRIPTION";
	public double rewardPoints = 10000;
	public double rewardPoints1 = 2000;
	public int max = 2;
	public int offSet = 1;
	public string success, box;
	RewardResponse callBack = new RewardResponse ();
	
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
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "CreateReward")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.CreateReward (cons.rewardName, rewardDescription, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "GetAllRewards")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetAllRewards (callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "GetRewardByName")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetRewardByName (cons.rewardName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "EarnRewards")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.EarnRewards (cons.gameName, cons.userName, cons.rewardName, rewardPoints1, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "RedeemRewards")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.RedeemRewards (cons.gameName, cons.userName, cons.rewardName, rewardPoints1, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "GetGameRewardPointsForUser")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetGameRewardPointsForUser (cons.gameName, cons.userName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "GetAllRewardsByPaging")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetAllRewards (max, offSet, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "GetAllRewardsCount")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetAllRewardsCount (callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "GetTopNRewardEarners")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetTopNRewardEarners (cons.gameName, cons.rewardName, max, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (890, 250, 200, 30), "GetAllRewardsByUser")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetAllRewardsByUser (cons.userName, cons.rewardName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (50, 300, 200, 30), "GetTopNRewardEarnersByGroup")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			IList<string> userList = new List<string> ();
			userList.Add (cons.userName);
			userList.Add (cons.userName1);
			rewardService.GetTopNRewardEarnersByGroup (cons.gameName, cons.rewardName, userList, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (260, 300, 200, 30), "GetUserRankingOnReward")) {
			rewardService = sp.BuildRewardService (); // Initializing Reward Service.
			rewardService.GetUserRankingOnReward (cons.gameName, cons.rewardName, cons.userName, callBack);
		}
	}
}
