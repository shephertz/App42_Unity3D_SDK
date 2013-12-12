using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.email;
using AssemblyCSharp;

public class EmailTest : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	EmailService emailService = null; // Initializing Email Service.
	
	public string success;
	EmailResponse callBack = new EmailResponse ();

	#if UNITY_EDITOR
	public static bool Validator (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
	{return true;}
	#endif
	void Start ()
	{
		#if UNITY_EDITOR
		ServicePointManager.ServerCertificateValidationCallback = Validator;
		#endif
		sp = new ServiceAPI (cons.apiKey,cons.secretKey);
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
