using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.game;
using AssemblyCSharp;
using System.Security.Cryptography.X509Certificates;

public class ScoreBoardTest : MonoBehaviour
{
	ServiceAPI sp = null;
	ScoreBoardService scoreBoardService = null; // Initializing ScoreBoard Service.
	Constant cons = new Constant ();
	public double userScore = 1000;
	public double Score1 = 2000;
	public int max = 2;
	public int offSet = 1;
	public string success;
	ScoreBoardResponse callBack = new ScoreBoardResponse ();
	
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
		
		//======================================{{{{************}}}}================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "SaveUserScore")) {
			App42Log.SetDebug (true);
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.SaveUserScore (cons.gameName, cons.userName, userScore, callBack);
		}
		
		//======================================{{{{************}}}}=================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "GetScoresByUser")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetScoresByUser (cons.gameName, cons.userName, callBack);	
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "GetHighestScoreByUser")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetHighestScoreByUser (cons.gameName, cons.userName, callBack);
		}
	
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "GetLowestScoreByUser")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetLowestScoreByUser (cons.gameName, cons.userName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "GetTopRankings")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetTopRankings (cons.gameName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "GetAverageScoreByUser")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetAverageScoreByUser (cons.gameName, cons.userName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "GetLastScoreByUser")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetLastScoreByUser (cons.gameName, cons.userName, callBack);
		}
			
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "GetTopRankings")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetTopRankings (cons.gameName, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "GetTopNRankings")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetTopNRankings (cons.gameName, max, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (890, 250, 200, 30), "GetTopNRankers")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			scoreBoardService.GetTopNRankers (cons.gameName, max, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (50, 300, 200, 30), "GetTopRankingsByGroup")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			IList<string> userList = new List<string> ();
			userList.Add (cons.userName);
			userList.Add (cons.userName1);
			scoreBoardService.GetTopRankingsByGroup (cons.gameName, userList, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (260, 300, 200, 30), "GetTopNRankersByGroup")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			IList<string> userList = new List<string> ();
			userList.Add (cons.userName);
			userList.Add (cons.userName1);
			scoreBoardService.GetTopNRankersByGroup (cons.gameName, userList, callBack);
		}
		
		//======================================{{{{************}}}}==========================================	
		if (GUI.Button (new Rect (470, 300, 200, 30), "EditScoreValueById")) {
			scoreBoardService = sp.BuildScoreBoardService (); // Initializing ScoreBoard Service.
			IList<string> userList = new List<string> ();
			userList.Add (cons.userName);
			userList.Add (cons.userName1);
			scoreBoardService.EditScoreValueById (cons.scoreId, userScore, callBack);
		}
	}
}
