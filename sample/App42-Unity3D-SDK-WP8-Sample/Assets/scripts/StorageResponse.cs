using System;
using com.shephertz.app42.paas.sdk.csharp.storage;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp
{
	public class StorageResponse : App42CallBack
	{
		private string result = "";
		 public void OnSuccess(object obj)
        {
			result = obj.ToString();
			if (obj is Storage)
			{
				Storage storage = (Storage)obj;
				Debug.Log ("Storage Response : " + storage);
				IList<Storage.JSONDocument> jsonDocList = storage.GetJsonDocList();
				for(int i=0;i<storage.GetJsonDocList().Count;i++){
					Debug.Log ("ObjectId is : " + jsonDocList[i].GetDocId());
					Debug.Log ("jsonDoc is : " + jsonDocList[i].GetJsonDoc());
				}
			}
		}
	
		
        public void OnException(Exception e)
        {
			result = e.ToString();
            Debug.Log ("Exception is : " + e);

		}
		
		public string getResult() {
			return result;
		}
		
		
	}
      
}

