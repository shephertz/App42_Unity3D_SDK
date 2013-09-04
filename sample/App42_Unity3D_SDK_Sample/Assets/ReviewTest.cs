using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.Net.Security;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.review;
using System.Security.Cryptography.X509Certificates;
using AssemblyCSharp;

public class ReviewTest : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	ReviewService reviewService = null; // Initializing Review Service.
	public string success, box;
	ReviewResponse callBack = new ReviewResponse ();

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
		if (GUI.Button (new Rect (50, 200, 200, 30), "Create Review")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.CreateReview (cons.userName, cons.itemId, "Awusume", 3,callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "Get Review ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetReviewsByItem (cons.itemId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "Get Highest Review ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetHighestReviewByItem (cons.itemId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "Get Lowest Review ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetLowestReviewByItem (cons.itemId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "Get Average Review ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetAverageReviewByItem (cons.itemId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "Get All Reviews")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetAllReviews (callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "Get All Reviews Count")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetAllReviewsCount (callBack);

		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "Add Comment")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.AddComment (cons.userName, cons.itemId, "Awsum app", callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "Get Comments ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetCommentsByItem (cons.itemId, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (890, 250, 200, 30), "Get Reviews Count ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetReviewsCountByItem (cons.itemId, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (50, 300, 250, 30), "GetReviews Count ByItem Rating")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetReviewsCountByItemAndRating (cons.itemId, cons.rating, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (310, 300, 100, 30), "Mute")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.Mute (cons.reviewId, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (420, 300, 100, 30), "Unmute")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.Unmute (cons.reviewId, callBack);
		}
		//===================================###################=========================================	
		if (GUI.Button (new Rect (530, 300, 200, 30), "Get All Reviews With Paging")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetAllReviews(cons.max,cons.offSet, callBack);
		}
		
		//===================================###################=========================================	
		if (GUI.Button (new Rect (740, 300, 180, 30), "Get Reviews ByItem")) {
			reviewService = sp.BuildReviewService (); // Initializing ReviewService.
			reviewService.GetReviewsByItem(cons.itemId,cons.max,cons.offSet, callBack);
		}
	}
}