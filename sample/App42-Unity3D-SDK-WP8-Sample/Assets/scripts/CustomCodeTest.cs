using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.customcode;
using AssemblyCSharp;
using SimpleJSON;

public class CustomCodeTest : MonoBehaviour {
	Constant cons = new Constant();
	ServiceAPI sp = null;
	CustomCodeService customCodeService = null; // Initializing CustomCode Service.
	
	public string success, box;
	CustomCodeResponse callBack = new CustomCodeResponse();

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
	void Update () {	
	}
	
	void OnGUI()
    {
		
		if (Time.time % 2 < 1) {
			success = callBack.getResult();
		}
      	// For Setting Up ResponseBox.
		GUI.TextArea(new Rect(10,5,1300,175), success);
		 
    //=========================================================================	
	if (GUI.Button(new Rect(50, 200, 200, 30), "Run Java Code"))
        {
			App42Log.SetDebug(true);
			customCodeService = sp.BuildCustomCodeService(); // Initializing CustomCodeService.
			JSONClass jsonBody = new JSONClass();
			jsonBody.Add("name" ,"John");
			jsonBody.Add("age",30);
            customCodeService.RunJavaCode(cons.customServiceName,jsonBody,new CustomCodeResponse());
		}
	}
}