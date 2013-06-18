using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;


public class App42_Unity_Sample : MonoBehaviour
{

    public string txt_user,txt_pass, txt_email, txt_name, log;
	 
    public static bool Validator(object sender, X509Certificate certificate, X509Chain chain,
                                      SslPolicyErrors sslPolicyErrors)
    {
        return true;
    }

    void Start()
    {
        ServicePointManager.ServerCertificateValidationCallback = Validator;
    }

    void Update()
    {

    }

    void OnGUI()
    {
		GUI.Label(new Rect(260, 10, 200, 20),"Username");
		GUI.Label(new Rect(260, 40, 200, 20),"Password");
		GUI.Label(new Rect(260, 70, 200, 20),"Email");
		GUI.Label(new Rect(610, 10, 200, 20),"Username");
        txt_user = GUI.TextField(new Rect(50, 10, 200, 20), txt_user);
        txt_pass = GUI.TextField(new Rect(50, 40, 200, 20), txt_pass);
        txt_email = GUI.TextField(new Rect(50, 70, 200, 20), txt_email);
        txt_name = GUI.TextField(new Rect(500, 10, 200, 20), txt_name);

        GUI.Label(new Rect(50, 200, 650, 100), log);

        if (GUI.Button(new Rect(50, 100, 200, 50), "Create User"))
        {
            ServiceAPI sp = new ServiceAPI("YOUR_API_KEY", "YOUR_SECRET_KEY");
            UserService userService = sp.BuildUserService();
            string userName = txt_user;
			
            string password = txt_pass;
            string emailId = txt_email;
            try
            {
                User user = userService.CreateUser(userName, password, emailId);
                //Debug.Log("User is " + user);
                log = "User : " + user.ToString();
            }
            catch (App42Exception e)
            {
                App42Log.Debug("Message : " + e.Message);
                log = "exception :" + e.Message;
            }

        }

        if (GUI.Button(new Rect(500, 100, 200, 50), "Get User"))
        {
            ServiceAPI sp = new ServiceAPI("YOUR_API_KEY", "YOUR_SECRET_KEY");
            UserService userService = sp.BuildUserService();
            string userName = txt_name;
            try
            {

                User response = userService.GetUser(userName);
                //Debug.Log("Get Method  is "+response.ToString());
                log = "User : " + response.ToString();
            }

            catch (App42Exception e)
            {
                App42Log.Debug("Message : " + e.Message);
                log = "exception :" + e.Message;
            }

        }
    }
}
