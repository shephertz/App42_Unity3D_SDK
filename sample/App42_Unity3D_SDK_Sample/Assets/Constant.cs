using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Constant 
	{
		public string apiKey  ="223c91f16cec32abf64c6dea5ab3e894151e9c5b72a10a03814afd7e3b27173f";						// API key that you have receieved after the success of app creation from AppHQ
		public string secretKey ="622dd65d3d7afd03f07cf70d9a35b189754959d7366cbcf036c6704d7cf60001";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string customApiKey  ="72e2bfc3eb51c60a8764ed3705510625baaa46691b111c9ffc7335a52003bf17";						// API key that you have receieved after the success of app creation from AppHQ
		public string customSecretKey ="ef92ccf8d71cb30272a66f0469b225969a8115e4de37f94f5fec0d708ee0e929";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string gameName ="testUnity";					// Name of the game which you can create from AppHQ console by clicking 
																	// Business Service -> Game Service -> Game -> Add Game
		public string userName  = "<Name of the User>"; 				// Name of the user for which you have to save score or create user etc. 
		public string userName1  = "<Name of the User>";				// Name of the user for which you have to save score or create user etc.
		public string sessionId  = "<Session Id of the User>";   					// Session id of the user for which you have to have invalidate his session 
		public string emailId  = "EmailId of The User";    		// EmailId for the user creation
		public string updateEmailId   ="<Id that has to be upadated>"; // EmailId for the updation
		
		
		//*************** Reward Service Credentials ************************//
		public string dbName="<dbName>";   							// Name of the database for which you have to add json document
		public string docId  = "<Object id of the User>";	 							// Object id of the json doc for which you have to fetch json doc, udate , delete etc..
		public string scoreId = "<Scoreid of the User>";							// Score id of the user for which you have to edit score , fetch user score etc..
		public string json = "{\"AppName\":\"devApp\",\"AppId\":\"123hg4bdb\"}"; 			// Json string which you want to save in insert json document
		public string key = "AppName"; 								// Key of json doc for fetch the doc details,update doc etc..
		public string val = "devApp"; 							// Value of json doc for fetch the doc details , updated doc etc..
		public string newJson = "{'AppName':'RealeaseApp'}"; 		// json string which you want to update from existing doc.
		public string channelName  = "channelName"; 				
		public string description  = "description here";
		
		public string deviceId  = "<Device Id>"; 				
		public string message  = "Phote"; 				
		public string deviceToken  = "Device Token"; 				
		public string albumName  = "albumName"; 				
		public string photoName  = "photoName"; 				
		public string itemId  = "itemId"; 		
		
		//*************** Review service Credentials ************************//
		
		public string reviewId  = "reviewId"; 
		
		//*************** Exception Service Credentials ************************//
		
		public string emailHost = "smtp.gmail.com";
		public Int64 emailPort = 465;
		public string mailId = "ronitsharma0010@gmail.com";
		public string emailPassword = "himanshu010";
		public bool isSSL = true;
		public string sendTo = "akshay.mishra@shephertz.co.in";
		public string sendSubject = "Tesing Unity Web Browser";
		public string sendMsg = "Himanshu is testing App42 Email Service For Unity";
		public int max = 5;
		public int rating = 3;
		public int offSet = 1;
		public string customServiceName = "monitor";
		
		
		//*************** Reward Service Credentials ************************//
		public string rewardName  = "Golden";				// Name of the reward for your game.
		public string attributeName = "JohnsValley";
		public string attributeValue = "Editor";
		public bool isCreate = false;
		
		//*************** Log Service Credentials ************************//
		public string module = "LogModule";
		public string eventName = "LogEvent";	
	}  
}

