using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.social;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class SocialTest : MonoBehaviour {
	
	//===========================================================================================
    Constant cons = new Constant();
	SocialResponse callBack = new SocialResponse();// Making callBack Object for SocialResponse.
	ServiceAPI sp = null;                         // Initializing Service API.
	SocialService socialService = null;          // Initializing Social Service.
	//===========================================================================================
	
	//============================DECLARING VARIABLES==============================================================================================================================================================
	public string userName = "<Name of the user>";             //faceBook,twitter,linkedIn
	public string status = "<Status that has to update on wall>";//faceBook,twitter,linkedIn
	
	public string appId = "<facebook_app_id>";                         //faceBook
	public string appSecret = "<facebook_app_secret>";                    //faceBook
	public string fbAccessToken = "<facebook_access_token>";
	
	public string consumerKey = "<twitter_consumer_key>";                                //twitter
	public string consumerSecret = "<twitter_consumer_secret>";      //twitter
	public string accessToken = "<twitter_access_token>";//twitter
	public string accessTokenSecret = "<twitter_access_token_secret>";//twitter
	
	public string linkedinApiKey = "<linkedin_api_key>";         //LinkedIn
	public string linkedinSecretKey = "<linkedin_secret_key>";           //LinkedIn
	public string linkedinAccessToken = "<linkedin_access_token>";//LinkedIn
	public string linkedinAccessTokenSecret = "<linkedin_access_token_secret>";//LinkedIn	
	
	public string success;
	//============================DECLARATION ENDS HERE=============================================================================================================================================================
	
	
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
			success = callBack.getResult();
		}
      
		// For Setting Up ResponseBox.
		GUI.TextArea(new Rect(10,5,1300,175), success);
		 

		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(50, 200, 200, 30), "LinkUserFacebookAccount"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserFacebookAccount(userName,fbAccessToken,appId,appSecret,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(260, 200, 200, 30), "LinkUserFacebookAccountAcsTkn"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserFacebookAccount(userName,fbAccessToken,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(470, 200, 200, 30), "UpdateFacebookStatus"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.UpdateFacebookStatus(userName,status,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(680, 200, 200, 30), "LinkUserTwitterAccount"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserTwitterAccount(userName,accessToken,accessTokenSecret,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(890, 200, 200, 30), "LinkUserTwitterAccount"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserTwitterAccount(userName,accessToken,accessTokenSecret,consumerKey,consumerSecret,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(50, 250, 200, 30), "UpdateTwitterStatus"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.UpdateTwitterStatus(userName,status,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(260, 250, 200, 30), "LinkUserLinkedInAccount"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserLinkedInAccount(userName,linkedinAccessToken,linkedinAccessTokenSecret,linkedinApiKey,linkedinSecretKey,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(470, 250, 200, 30), "LinkUserLinkedInAccount"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.LinkUserLinkedInAccount(userName,accessToken,accessTokenSecret,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(680, 250, 200, 30), "UpdateLinkedInStatus"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.UpdateLinkedInStatus(userName,status,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(890, 250, 200, 30), "UpdateSocialStatusForAll"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.UpdateSocialStatusForAll(userName,status,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(50, 300, 200, 30), "GetFacebookFriendsFromLinkUser"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.GetFacebookFriendsFromLinkUser(userName,callBack);
			}
		
		//=======================================SOCIAL_SERVICE=======================================
		 
		if (GUI.Button(new Rect(260, 300, 200, 30), "GetFacebookFriendsFromAccessToken"))
	        {
				socialService = sp.BuildSocialService(); // Initializing Social Service.
				socialService.GetFacebookFriendsFromAccessToken(accessToken,callBack);
			}
		
	}
}
