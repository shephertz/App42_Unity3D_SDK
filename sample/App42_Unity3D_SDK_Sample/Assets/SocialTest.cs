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
	public string userName = "Aks"+ DateTime.Now.Ticks;             //faceBook,twitter,linkedIn
	public string status = "Hi I M Using App42 Social For Unity3D";//faceBook,twitter,linkedIn
	
	public string appId = "";                         //faceBook
	public string appSecret = "";                    //faceBook
	public string fbAccessToken = "448838959-CAAG0kEdZAftwBAM2KXj1vXMJ1RU95ymmKlAdOltuGiEdq4HZCO0QXd8xO2BmCjj16EvKp79XzrW98fmeloIChKzQPgVdzHZBXxVfLBL2Fb2fL7ZCQa2CT8tnwpkkbsPSzR0LqNgZAZCaNL0PLLIbUNVG1PE9W7UaQZD";
	
	public string consumerKey = "6lFvyAd515aKrFDwL8DA";                                //twitter
	public string consumerSecret = "uFQ4QBr1fxcTthcB7bE5yvnaq8Jv3EUD4bAQRk8vNs";      //twitter
	public string accessToken = "448838959-m67CV2QqqizC6tKwS88R8K7YxTts54HPmUv4EfJC";//twitter
	public string accessTokenSecret = "mgyFruxAopBkJdQAOS3zSBqn8SqjkRpgw8oJJZKV9vg";//twitter
	
	public string linkedinApiKey = "gdsxb5wr6bow";         //LinkedIn
	public string linkedinSecretKey = "YQ345Y4AqI2WSMjp";           //LinkedIn
	public string linkedinAccessToken = "56a813dd-5b61-48f4-8cd6-cb49b40081f6";//LinkedIn
	public string linkedinAccessTokenSecret = "7d81cb5b-d9ee-4ebb-8750-2f822ebd8aa2";//LinkedIn	
	
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
