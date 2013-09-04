using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.social;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class SocialResponse : App42CallBack
	{
		private string result = "";

		public void OnSuccess (object social)
		{
			result = social.ToString ();
			if (social is Social) {
				Social socialObj = (Social)social;
				if (socialObj.GetFacebookAccessToken () != null) {
					App42Log.Console ("AccessToken : " + socialObj.GetFacebookAccessToken ());
					App42Log.Console ("BuddyName : " + socialObj.GetFacebookAppId ());
					App42Log.Console ("BuddyName : " + socialObj.GetFacebookAppSecret ());
					if (socialObj.GetFriendList () != null) {
						IList<Social.Friends> friendList = socialObj.GetFriendList ();
						for (int i= 0; i<friendList.Count; i++) {
							App42Log.Console ("Friends Name is  : " + friendList [i].GetName ());
							App42Log.Console ("Friends Id is : " + friendList [i].GetId ());
							App42Log.Console ("Friends AppInstalled is : " + friendList [i].GetInstalled ());
							App42Log.Console ("Friends Image is : " + friendList [i].GetPicture ());
						}
					}
				} else if (socialObj.GetTwitterAccessToken () != null) {
					App42Log.Console ("AccessToken is : " + socialObj.GetTwitterAccessToken ());
					App42Log.Console ("AccessTokenSecret is : " + socialObj.GetTwitterAccessTokenSecret ());
					App42Log.Console ("TwitterConsumerKey is : " + socialObj.GetTwitterConsumerKey ());
					App42Log.Console ("TwitterConsumerSecret is : " + socialObj.GetTwitterConsumerSecret ());
					
				} else if (socialObj.GetLinkedinAccessToken () != null) {
					App42Log.Console ("AccessToken is : " + socialObj.GetLinkedinAccessToken ());
					App42Log.Console ("AccessTokenSecret is : " + socialObj.GetLinkedinAccessTokenSecret ());
					App42Log.Console ("LinkedInApiKey is : " + socialObj.GetLinkedinApiKey ());
					App42Log.Console ("LinkedinSecretKey is : " + socialObj.GetLinkedinSecretKey ());
				} else {
					App42Log.Console ("UserName is : " + socialObj.GetUserName ());
					App42Log.Console ("Staus is : " + socialObj.GetStatus ());
				}
			}
		}
	
		public void OnException (Exception e)
		{
			result = e.ToString ();
		}
		
		public string getResult ()
		{
			return result;
		}	
	}
}

