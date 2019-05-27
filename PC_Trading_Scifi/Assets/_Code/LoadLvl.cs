using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvl : MonoBehaviour {

	public string sceneName; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void LoadScene () {

		SceneManager.LoadScene (sceneName);

	}

	public void ExitButton () {

		Application.Quit ();

	}

}
