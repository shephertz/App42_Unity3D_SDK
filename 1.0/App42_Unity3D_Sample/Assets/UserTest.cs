using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class UserTest : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	UserService userService = null; // Initializing User Service.
	User createUserObj = null;
	public string password = "password";
	public int max = 2;
	public int offSet = 1;
	public string success, box;
	UserResponse callBack = new UserResponse ();

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
		 
		//=========================================================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "Create User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.CreateUser (cons.userName, password, cons.emailId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "Get User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetUser (cons.userName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "Get All Users")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetAllUsers (callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "Update Email")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.UpdateEmail (cons.userName, cons.emailId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "Delete User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.DeleteUser (cons.userName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "Authenticate User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.Authenticate (cons.userName, password, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "Change UserPassword")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.ChangeUserPassword (cons.userName, password, "newPassWord", callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "Lock User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.LockUser (cons.userName, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "Unlock User")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.UnlockUser (cons.userName, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (890, 250, 200, 30), "Get LockedUsers")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetLockedUsers (callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (50, 300, 200, 30), "GetAllUsersByPaging")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetAllUsers (max, offSet, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (260, 300, 200, 30), "GetAllUsersCount")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetAllUsersCount (callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (470, 300, 200, 30), "ResetUserPassword")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.ResetUserPassword (cons.userName, password, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (680, 300, 200, 30), "ResetUserPassword")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.ResetUserPassword (cons.userName, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (890, 300, 200, 30), "Log out")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.Logout (cons.sessionId, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (50, 350, 200, 30), "GetLockedUsersCount")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetLockedUsersCount (callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (260, 350, 200, 30), "GetUserByEmailId")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetUserByEmailId (cons.updateEmailId, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (470, 350, 200, 30), "GetLockedUsersByPaging")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			userService.GetLockedUsers (max, offSet, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (680, 350, 200, 30), "CreateOrUpdateProfile")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			
			User.Profile profileObj = new User.Profile (createUserObj);
			profileObj.SetCountry ("India");
			profileObj.SetCity ("GGN");
			profileObj.SetFirstName ("Akshay");
			profileObj.SetLastName ("Mishra");
			profileObj.SetHomeLandLine ("1234567890");
			profileObj.SetMobile ("12345678900987654321");
			profileObj.SetOfficeLandLine ("0987654321");
			profileObj.SetSex (UserGender.MALE);
			profileObj.SetState ("UP");
			
			userService.CreateOrUpdateProfile (createUserObj, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (890, 350, 200, 30), "CreateUserWithRole")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			
			IList<string> roleList = new List<string> ();
			roleList.Add ("Admin");
			roleList.Add ("Manager");
			roleList.Add ("Programmer");
			roleList.Add ("Tester");
			userService.CreateUser (cons.userName, password, cons.emailId, roleList, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (50, 400, 200, 30), "AssignRoles")) {
			userService = sp.BuildUserService (); // Initializing UserService.
			
			IList<string> roleList = new List<string> ();
			roleList.Add ("Designer");
			roleList.Add ("Architect");
			
			userService.AssignRoles (cons.userName, roleList, callBack);
		}
		
	}
}