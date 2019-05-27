using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour 
{

//	public GameObject textPaused;

	//public PlayerController thePlayer;



	void Start () {
		
	}


	void Update ()
	{

		if (Input.GetKeyDown ("p")) {	//When I press P
			GamePauser ();				//Run this Function
			print ("P was pressed.");	//Tell me in Console
		}
	}


	public void GamePauser()					//Toggle Between Pause and not Pause
	{

			if (Time.timeScale == 1) {			//If timescale = 1, then set it to 0
//				textPaused.SetActive (true);
//				thePlayer.enabled = false;
				Time.timeScale = 0;
		} else {								//If timescale = 0, then set it to 1
				Time.timeScale = 1;
//				thePlayer.enabled = true;
//				textPaused.SetActive (false);
			}

	

	}

}
