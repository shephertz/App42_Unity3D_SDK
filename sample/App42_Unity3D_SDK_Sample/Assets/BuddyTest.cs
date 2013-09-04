using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.geo;
using com.shephertz.app42.paas.sdk.csharp.buddy;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class BuddyTest : MonoBehaviour {
	
	Constant cons = new Constant();
	ServiceAPI sp = null;              //Initializing Service API
	BuddyService buddyService = null; // Initializing Buddy Service.
	BuddyResponse callback = new BuddyResponse();//Making CallBack Object For BuddyResponse.
	
	
	public string userName = "Paul";
	public string buddyName = "Nick";
	public string buddyName1 = "Aks";
	public string buddyName2 = "Juno";
	public string message = "Hi I Am Using App42 BuddyService";
	public string groupName = "App42BuddyGroup";
	public string ownerName = "Paul";
	public double maxDistance = 1000;
	
	
	public string success;
	
	public static bool Validator(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
   	 	return true;
    }
	
	// Use this for initialization
	void Start () {
	ServicePointManager.ServerCertificateValidationCallback = Validator;
		sp = new ServiceAPI(cons.apiKey,cons.secretKey);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
    {
		
		if (Time.time % 2 < 1) {
			success = callback.getResult();
		}
      
		// For Setting Up ResponseBox.
		GUI.TextArea(new Rect(10,5,1300,175), success);
		 
        //=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(50, 200, 200, 30), "SendFriendRequest"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.SendFriendRequest(userName,buddyName,message, callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(260, 200, 200, 30), "GetFriendRequest"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.GetFriendRequest(buddyName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(470, 200, 200, 30), "AcceptFriendRequest"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.AcceptFriendRequest(buddyName,userName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(680, 200, 200, 30), "RejectFriendRequest"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.RejectFriendRequest(buddyName,userName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(890, 200, 200, 30), "GetAllFriends"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.GetAllFriends(userName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(50, 250, 200, 30), "CreateGroupByUser"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.CreateGroupByUser(userName,groupName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(260, 250, 200, 30), "AddFriendToGroup"))
	        {
			IList<string> friendList = new List<string>();
			friendList.Add("Akshay");
			friendList.Add("Neena");
			friendList.Add("Zin");
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.AddFriendToGroup(userName,groupName,friendList,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(470, 250, 200, 30), "BlockUser"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.BlockUser(userName,buddyName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(680, 250, 200, 30), "UnblockUser"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.UnblockUser(userName,buddyName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(890, 250, 200, 30), "BlockFriendRequest"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.BlockFriendRequest(userName,buddyName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(50, 300, 200, 30), "GetAllGroups"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.GetAllGroups(userName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(260, 300, 200, 30), "GetAllFriendsInGroup"))
	        {
				buddyService = sp.BuildBuddyService();// Initializing BuddyService.
				buddyService.GetAllFriendsInGroup(userName, ownerName, groupName,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(470, 300, 200, 30), "CheckedInGeoLocation"))
	        {
			GeoPoint gp = new GeoPoint();
			gp.SetLng(28.409195800000000000);
			gp.SetLat(77.047811200000070000);
			gp.SetMarker("Himalya");
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.CheckedInGeoLocation(userName,gp,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(680, 300, 200, 30), "GetFriendsByLocation"))
	        {
			double latitude = 77.047811200000070000;
			double longitude = 28.409195800000000000;
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.GetFriendsByLocation(userName, latitude, longitude, maxDistance,5,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(890, 300, 200, 30), "SendMessageToGroup"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.SendMessageToGroup(userName, ownerName, groupName, message,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(50, 350, 200, 30), "SendMessageToFriend"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.SendMessageToFriend(userName, buddyName, message,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(260, 350, 200, 30), "SendMessageToFriends"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.SendMessageToFriends(userName, message,callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(470, 350, 200, 30), "GetAllMessages"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.GetAllMessages(userName, callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(680, 350, 200, 30), "GetAllMessagesFromBuddy"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.GetAllMessagesFromBuddy(userName, buddyName, callback);
			}
		
		//=======================================BUDDY_SERVICE================================================	
		 
		if (GUI.Button(new Rect(890, 350, 200, 30), "GetAllMessagesFromGroup"))
	        {
			buddyService = sp.BuildBuddyService();// Initializing BuddyService.
			buddyService.GetAllMessagesFromGroup(userName, ownerName, groupName, callback);
			}
		
		
}
}
