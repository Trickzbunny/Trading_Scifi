using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Need to access the SceneManagement that I can load the other scenes.

/*
Jeffrey Lay
This Script will Load a Level after X seconds once this script is Active.

Place this script on a GameObject that is not active. So once something happens, this GameObject gets enabled, therefore the script will load a new level.
Use in combination with MoveSmoke Script for a nice effect.
*/


public class LoadLevel : MonoBehaviour 
{
	
	public		string 		sceneName;					// Allows you to directly write the scene Name which needs to be loaded
	public 		float 		delayLoad;					// An Invoke that delays the load time after this script is active.



	void Start () 
	{
		Time.timeScale = 1;
		Invoke ("LoadedLevel", delayLoad);				// When script is Active there will be a delay before the scene is loaded.
	}	






void LoadedLevel()
	{
		SceneManager.LoadScene (sceneName);				// Loads the scene that is written.	
	}


}
