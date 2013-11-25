using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Constant 
	{
		public string apiKey  ="<Your_API_KEY>";						// API key that you have receieved after the success of app creation from AppHQ
		public string secretKey ="<Your_SECRET_KEY>";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string gameName ="<Your_Game_Name>";						// Name of the game which you can create from AppHQ console by clicking 
																		// Business Service -> Game Service -> Game -> Add Game
		public string description  = "<Enter_the_description>";			// Enter your description
		public string userName  = "<Name of the User>"; 				// Name of the user for which you have to save score or create user etc. 
		public string userName1  = "<Name of the User>";				// Name of the user for which you have to save score or create user etc.
		public string sessionId  = "<Session Id of the User>";   		// Session id of the user for which you have to have invalidate his session 
		public string emailId  = "<EmailId of The User>";    			// EmailId for the user creation
		public string updateEmailId   ="<Id that has to be upadated>";  // EmailId which has to be updated in user profile.
		
		public string dbName="<Enter_Your_DbName>";   					// Name of the database for which you have to add json document
		public string docId  = "<Object id of the User>";	 			// Object id of the json doc for which you have to fetch json doc,
																		// update , delete etc..
		public string scoreId = "<Scoreid of the User>";				// Score id of the user for which you have to edit score , fetch user score etc..
		public string json = "{\"AppName\":\"devApp\",\"AppId\":\"123hg4bdb\"}"; 			// Json string which you want to save in insert json document
		public string key = "<Enter_The_Key>"; 							// Key of json doc for fetch the doc details,update doc etc..
		public string val = "<Enter_The_Value>"; 						// Value of json doc for fetch the doc details , updated doc etc..
		public string newJson = "{'AppName':'RealeaseApp'}"; 			// json string which you want to update from existing doc.
		
		public string channelName  = "<Enter_the_channel_name>"; 		// Enter your ChannelName which you have to subscribe for PushNotification		
		
		public string deviceId  = "<Enter_the_deviceId>"; 				// Enter your DeviceId for which you have to send messages etc.
		public string message  = "<Enter_the_message>"; 				// Enter your message which you wan't to send.
		public string deviceToken  = "<Enter_the_deviceToken>"; 
		
		public string itemId  = "<Enter_the_itemId>"; 					// Enter the id or the item for which you wan't to create review of fetching details.
		public string reviewId  = "<Enter_the_reviewId>"; 				// Enter the review id for which you wan't to fetch the details.
		
		public int max = 5;
		public int rating = 3;
		public int offSet = 1;
		public string customServiceName = "<Enter_Service_Name>";		// Enter your service Name for which you want to run your custom code.
		public string rewardName  = "<Enter_Reward_Name>";				// Name of the reward for your game.
		public string attributeName = "<Enter_Attribute_Name>";			// Name of the attribute
		public string attributeValue = "<Enter_Attribute_Value>";
		public bool isCreate = false;
		public string module = "<Enter_Your_Module>";					// Name of the module for which you create log
		public string eventName = "<Enter_Event_Name>";	
		
		public string emailHost = "<Enter_the_email_host>";
		public Int64 emailPort = 465;
		public string mailId = "<Enter_Your_EmailId>";					// Email id of the user which you want to configure with App42
		public string emailPassword = "<Enter_email_password>";			// Enter your email password which you have configure with App42	
		public bool isSSL = true;
		public string sendTo = "<Enter_Receiver_EMailId>";
		public string sendSubject = "<Enter_Email_Subject>";
		public string sendMsg = "Thanks for register.";				  // Enter the message which you want to send.
		
		public string achievementName = "<Your_Achievement_Name>";    // Name of the achievement you want to create or earn.
	
	}  
}

