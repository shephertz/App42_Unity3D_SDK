using System;
using com.shephertz.app42.paas.sdk.csharp.review;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class ReviewResponse : App42CallBack
	{
		private string result = "";

		public void OnSuccess (object response)
		{
			result = response.ToString();
			if (response is Review) {
				Review review = (Review)response;
				Debug.Log ("GetItemId  : " + review.GetItemId ());
				Debug.Log ("GetRating  : " + review.GetRating ());
				Debug.Log ("GetReviewId  : " + review.GetReviewId ());
				Debug.Log ("GetStatus  : " + review.GetStatus ());
				Debug.Log ("GetStrResponse  : " + review.GetStrResponse ());
				Debug.Log ("GetComment  : " + review.GetComment ());
				Debug.Log ("GetCreatedOn  : " + review.GetCreatedOn ());
				Debug.Log ("GetUserId  : " + review.GetUserId ());
				
			} else { 
				IList<Review> reviewList = (IList<Review>)response;
				for (int i=0; i<reviewList.Count; i++) {
					Debug.Log ("GetItemId  : " + reviewList [i].GetItemId ());
					Debug.Log ("GetRating  : " + reviewList [i].GetRating ());
					Debug.Log ("GetReviewId  : " + reviewList [i].GetReviewId ());
					Debug.Log ("GetStatus  : " + reviewList [i].GetStatus ());
					Debug.Log ("GetStrResponse  : " + reviewList [i].GetStrResponse ());
					Debug.Log ("GetComment  : " + reviewList [i].GetComment ());
					Debug.Log ("GetCreatedOn  : " + reviewList [i].GetCreatedOn ());
					Debug.Log ("GetUserId  : " + reviewList [i].GetUserId ());
				}
			}
		}
	
		public void OnException (Exception e)
		{
			result = e.ToString ();
			Debug.Log ("Exception : " + e);
		}
		
		public string getResult ()
		{
			return result;
		}	
	}
}

