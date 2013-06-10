using UnityEngine;
using System.Collections;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;

public class App42_Unity_Sample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if(GUI.Button(new Rect(50,50,50,50),"Post")){
		ServiceAPI sp = new ServiceAPI("YOUR_API_KEY","YOUR_SECRET_KEY");
		UserService userService  = sp.BuildUserService();
		string userName = "Nick";
		string password = "*******";
		string emailId = "Nick@shephertz.co.in";
			
		User user  = userService.CreateUser(userName,password,emailId);
		Debug.Log("User is         " + user);
			
		}
		
		if(GUI.Button(new Rect(500,50,50,50),"Get")){
		ServiceAPI sp = new ServiceAPI("YOUR_API_KEY","YOUR_SECRET_KEY");
		UserService userService  = sp.BuildUserService();
		string userName = "Nick";
		User response  = userService.GetUser(userName);
		Debug.Log("Get Method  is	 "+response.ToString());
			
		}
	}
}
