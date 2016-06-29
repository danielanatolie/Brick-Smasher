using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name) {
		Debug.Log("Level load request for: "+name);
		Application.LoadLevel(name);
	}
	public void quitRequest(string name) {
		Debug.Log ("Quit requested.");
		Application.Quit();
	}
	
	// Load the next level according to the build settings
	public void loadNextLevel() {
		Application.LoadLevel(Application.loadedLevel+1);
	}
}
