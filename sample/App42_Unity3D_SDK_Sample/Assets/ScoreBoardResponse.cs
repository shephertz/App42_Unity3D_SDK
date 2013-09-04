using System;
using com.shephertz.app42.paas.sdk.csharp.game;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class ScoreBoardResponse : App42CallBack
	{
		private string result = "";
		
		public void OnSuccess (object obj)
		{
			if (obj is Game) {
				Game gameObj = (Game)obj;
				result = gameObj.ToString ();
				Debug.Log ("GameName : " + gameObj.GetName ());
				if (gameObj.GetScoreList () != null) {
					IList<Game.Score> scoreList = gameObj.GetScoreList ();
					for (int i = 0; i < scoreList.Count; i++) {
						Debug.Log ("UserName is  : " + scoreList [i].GetUserName ());
						Debug.Log ("CreatedOn is  : " + scoreList [i].GetCreatedOn ());
						Debug.Log ("ScoreId is  : " + scoreList [i].GetScoreId ());
						Debug.Log ("Value is  : " + scoreList [i].GetValue ());
					}
				}
			} else {
				IList<Game> game = (IList<Game>)obj;
				result = game.ToString ();
				for (int j = 0; j < game.Count; j++) {
					Debug.Log ("GameName is   : " + game [j].GetName ());
					Debug.Log ("Description is  : " + game [j].GetDesription ());
				}
			}
					
		}
		
		public void OnException (Exception e)
		{
			result = e.ToString ();
			Debug.Log ("EXCEPTION : " + e);
	
		}
		
		public string getResult ()
		{
			return result;
		}
		
	}
      
}

