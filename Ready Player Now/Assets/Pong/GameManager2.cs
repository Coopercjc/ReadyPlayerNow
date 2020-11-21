using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour {

	public static int PlayerScore1 = 0;
	public static int PlayerScore2 = 0;
	public bool useGameSceneManager = true;

	public GUISkin layout;

	GameObject theBall;

	// Use this for initialization
	void Start () {
		theBall = GameObject.FindGameObjectWithTag ("Ball");
	}

	public static void Score(string wallID) {
		if (wallID == "RightWall") {
			PlayerScore1++;
		} else {
			PlayerScore2++;
		}
	}

	void OnGUI() {
		GUI.skin = layout;
		GUI.Label (new Rect (Screen.width / 2 - 95 - 12, 20, 100, 100), "" + PlayerScore1);
		GUI.Label (new Rect (Screen.width / 2 + 65 + 12, 20, 100, 100), "" + PlayerScore2);

		/*if (GUI.Button (new Rect (Screen.width / 2 - 60, 35, 120, 53), "RESTART")) {
			PlayerScore1 = 0;
			PlayerScore2 = 0;
			theBall.SendMessage ("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
		}*/

		if (PlayerScore1 == 5) {
			GUI.Label (new Rect (Screen.width / 2 - 105, 200, 2000, 1000), "YOU LOSE");
			theBall.SendMessage ("ResetBall", null, SendMessageOptions.RequireReceiver);
			StartCoroutine(waitLoss ());
		} else if (PlayerScore2 == 5) {
			GUI.Label (new Rect (Screen.width / 2 - 90, 200, 2000, 1000), "YOU WIN");
			theBall.SendMessage ("ResetBall", null, SendMessageOptions.RequireReceiver);
			StartCoroutine(waitWin ());
		}
	}

	IEnumerator waitLoss() {
		yield return new WaitForSeconds(2.0f);
		PlayerScore1=0;
		PlayerScore2=0;
		SceneManager.LoadScene(3);
	}
	
	IEnumerator waitWin() {
		yield return new WaitForSeconds(2.0f);
		secondsKeeper.Show3 = true;
		SceneManager.LoadScene(10);
	}

}
