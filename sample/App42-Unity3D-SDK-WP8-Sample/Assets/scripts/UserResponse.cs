using System;
using com.shephertz.app42.paas.sdk.csharp.user;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class UserResponse : App42CallBack
	{
		private string result = "";
		 public void OnSuccess(object user)
        {
			try
            {
                if (user is User)
                {
                    User userObj = (User)user;
					result = userObj.ToString();
                    Debug.Log ("UserName : " + userObj.GetUserName());
                    Debug.Log ("EmailId : " + userObj.GetEmail());
                    User.Profile profileObj = (User.Profile)userObj.GetProfile();
                    if (profileObj != null )
                    {
                        Debug.Log ("FIRST NAME" + profileObj.GetFirstName());
                        Debug.Log ("SEX" + profileObj.GetSex());
                        Debug.Log ("LAST NAME" + profileObj.GetLastName());
                    }
                }
                else
                {
                    IList<User> userList = (IList<User>)user;
                    result = userList[0].ToString();
            		Debug.Log ("UserName : " + userList[0].GetUserName());
                    Debug.Log ("EmailId : " + userList[0].GetEmail());
                    
                }
            }
            catch (App42Exception e)
            {
				result = e.ToString();
       			Debug.Log ("App42Exception : "+ e);
            }
		}
	
        public void OnException(Exception e)
        {
			result = e.ToString();
            Debug.Log ("Exception : " + e);
		}
		
		public string getResult() {
			return result;
		}	
	}
}

