using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	// Recall that we have a hierarchy of scripting calls that occur just when the game awakens:
	// So techinicaly the music player runs twice during the intial awake, so we need to destroy the duplicate during the awake.
	void Awake() {
		if(instance != null) {
			Destroy(gameObject);
			print("Duplicate music player self-destructed!");
		} else {
			instance = this;
			// Run the music [gameObject] on every scene
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
