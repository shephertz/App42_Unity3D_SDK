using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.email;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class EmailTest : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	EmailService emailService = null; // Initializing Email Service.
	
	public string success;
	EmailResponse callBack = new EmailResponse ();
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
		 

		//=======================================EMAIL_SERVICE=======================================
		 
		if (GUI.Button (new Rect (50, 200, 200, 30), "CreateMailConfiguration")) {
			App42Log.SetDebug(true);
				
			emailService = sp.BuildEmailService (); // Initializing Email Service.
			emailService.CreateMailConfiguration (cons.emailHost, cons.emailPort, cons.mailId, cons.emailPassword, cons.isSSL, callBack);
		}
		
		//=======================================EMAIL_SERVICE=======================================
		 
		if (GUI.Button (new Rect (260, 200, 200, 30), "RemoveEmailConfiguration")) {
			emailService = sp.BuildEmailService (); // Initializing Email Service.
			emailService.RemoveEmailConfiguration (cons.mailId, callBack);
		}
		
		//=======================================EMAIL_SERVICE=======================================
		 
		if (GUI.Button (new Rect (470, 200, 200, 30), "GetEmailConfigurations")) {
			emailService = sp.BuildEmailService (); // Initializing Email Service.
			emailService.GetEmailConfigurations (callBack);
		}
		
		//=======================================EMAIL_SERVICE=======================================
		 
		if (GUI.Button (new Rect (680, 200, 200, 30), "SendMail")) {
			emailService = sp.BuildEmailService (); // Initializing Email Service.
			emailService.SendMail (cons.sendTo, cons.sendSubject, cons.sendMsg, cons.mailId, EmailMIME.PLAIN_TEXT_MIME_TYPE, callBack);
		}
	}
}
