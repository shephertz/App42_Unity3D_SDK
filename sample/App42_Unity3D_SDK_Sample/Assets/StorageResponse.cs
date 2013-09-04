using System;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
namespace AssemblyCSharp
{
	public class StorageResponse : App42CallBack
	{
		private string result = "";
		 public void OnSuccess(object storage)
        {
			result = storage.ToString();
            try
            {
                if (storage is Storage)
                {
					Storage storageObj = (Storage)storage;
					Debug.Log ("Storage Response : " + storageObj);
                }
                else
                {
                    Debug.Log ("I DNT KNW WHO I M");
                }
            }
            catch (App42Exception e)
            {
					Debug.Log ("I DNT KNW WHO I M"+ e);
                }
		}
	
		
        public void OnException(Exception e)
        {
			result = e.ToString();
            Debug.Log ("EXCEPTION" + e);

		}
		
		public string getResult() {
			return result;
		}
		
		
	}
      
}

