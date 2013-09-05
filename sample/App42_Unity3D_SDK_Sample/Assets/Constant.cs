using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Constant 
	{
		public string apiKey  ="<Your_API_KEY>";						// API key that you have receieved after the success of app creation from AppHQ
		public string secretKey ="<Your_SECRET_KEY>";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string customApiKey  ="<Your_API_KEY>";						// API key that you have receieved after the success of app creation from AppHQ
		public string customSecretKey ="<Your_SECRET_KEY>";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string gameName ="<Your_Game_Name>";					// Name of the game which you can create from AppHQ console by clicking 
																	// Business Service -> Game Service -> Game -> Add Game
		public string description  = "<Enter_the_description>";
		public string userName  = "<Name of the User>"; 				// Name of the user for which you have to save score or create user etc. 
		public string userName1  = "<Name of the User>";				// Name of the user for which you have to save score or create user etc.
		public string sessionId  = "<Session Id of the User>";   					// Session id of the user for which you have to have invalidate his session 
		public string emailId  = "<EmailId of The User>";    		// EmailId for the user creation
		public string updateEmailId   ="<Id that has to be upadated>"; // EmailId for the updation
		
		public string dbName="<dbName>";   							// Name of the database for which you have to add json document
		public string docId  = "<Object id of the User>";	 							// Object id of the json doc for which you have to fetch json doc, udate , delete etc..
		public string scoreId = "<Scoreid of the User>";							// Score id of the user for which you have to edit score , fetch user score etc..
		public string json = "{\"AppName\":\"devApp\",\"AppId\":\"123hg4bdb\"}"; 			// Json string which you want to save in insert json document
		public string key = "<Enter_The_Key>"; 								// Key of json doc for fetch the doc details,update doc etc..
		public string val = "<Enter_The_Value>"; 							// Value of json doc for fetch the doc details , updated doc etc..
		public string newJson = "{'AppName':'RealeaseApp'}"; 		// json string which you want to update from existing doc.
		
		public string channelName  = "<Enter_the_channel_name>"; 				
		
		public string deviceId  = "<Enter_the_deviceId>"; 				
		public string message  = "<Enter_the_message>"; 				
		public string deviceToken  = "<Enter_the_deviceToken>"; 				
		public string albumName  = "<Enter_the_album_name>"; 				
		public string photoName  = "<Enter_the_photo_name>"; 				
		public string itemId  = "<Enter_the_itemId>"; 		
		public string reviewId  = "<Enter_the_reviewId>"; 
		
		public int max = 5;
		public int rating = 3;
		public int offSet = 1;
		public string customServiceName = "monitor";
		public string rewardName  = "Golden";				// Name of the reward for your game.
		public string attributeName = "JohnsValley";
		public string attributeValue = "Editor";
		public bool isCreate = false;
		public string module = "LogModule";
		public string eventName = "LogEvent";	
		/**************** Email Service Credentials ********************************/
		public string emailHost = "<Enter_the_email_host>";
		public Int64 emailPort = 465;
		public string mailId = "ronitsharma0010@gmail.com";
		public string emailPassword = "himanshu010";
		public bool isSSL = true;
		public string sendTo = "akshay.mishra@shephertz.co.in";
		public string sendSubject = "Tesing Unity Web Browser";
		public string sendMsg = "Himanshu is testing App42 Email Service For Unity";
	
	}  
}

