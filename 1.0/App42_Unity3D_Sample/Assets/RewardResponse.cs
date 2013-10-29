using System;
using com.shephertz.app42.paas.sdk.csharp.reward;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class RewardResponse : App42CallBack
	{
		private string result = "";
		
		 public void OnSuccess(object obj)
        {
			try
            {
				if (obj is Reward)
                {
                    Reward rewardObj = (Reward)obj;
					result = rewardObj.ToString();
            
                    Debug.Log ("GetName : " + rewardObj.GetName());
                    Debug.Log ("GetGameName : " + rewardObj.GetGameName());
                }
                
				else {
					IList<Reward> rewardList = (IList<Reward>)obj;
					result = rewardList[0].ToString();
					Debug.Log("RewardResponse  "+ rewardList[0] );
                    Debug.Log ("GetName : " + rewardList[0].GetName());
                    Debug.Log ("GetGameName : " + rewardList[0].GetGameName());
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
			Debug.Log ("EXCEPTION  :  " + e);
		}
		
		public string getResult() {
			return result;
		}
		
	}
      
}

