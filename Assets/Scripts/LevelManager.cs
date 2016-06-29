using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name) {
		Debug.Log("Level load request for: "+name);
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	public void quitRequest(string name) {
		Debug.Log ("Quit requested.");
		Application.Quit();
	}
	
	// Load the next level according to the build settings
	public void loadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel+1);
	}
	
	public void BrickDestroyed() {
		//if last brick is destroyed, load the next level:
		if(Brick.breakableCount <= 0) {
			loadNextLevel();
		}
	}
}
