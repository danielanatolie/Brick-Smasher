using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites; 
	
	private int timesHit;
	private LevelManager levelManager;
	
	// Brick count will help indicate which brick 
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		bool  isBreakable = (this.tag == "Breakable");
		if(isBreakable) {
			HandleHits();
		}
	}
	
	void HandleHits() {
		timesHit++; 
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		// If we don't have the next sprite, don't try to load the sprite
		if(hitSprites[spriteIndex]) {
			// Dealing with the brick, get the sprite renderer to change it to new sprite in array
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// TODO remove this method once we can actually win! 
	void SimulateWin() {
		levelManager.loadNextLevel();
		
	}
}
