using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	
	public Sprite[] hitSprites; 
	// Brick-damage count will help indicate when to load next level
	public static int breakableCount  = 0;
	
	private int timesHit;
	private LevelManager levelManager;
	private bool  isBreakable; 
	
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if(isBreakable) {
			breakableCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		// Play the "cracking sound" when the brick is hit at a sound level of 0.8f
		AudioSource.PlayClipAtPoint(crack, transform.position, 0.5f);
		if(isBreakable) {
			HandleHits();
		}
	}
	
	void HandleHits() {
		timesHit++; 
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			// The brick is not being broken any more, it is being destroyed...
			breakableCount--;
			// Check if this is the last brick destroyed using levelManager (which has a method to check if breakableCount <= 0 at this point, meaning no more bricks remaining:
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		// If we don't have the next sprite, don't try to load the sprite
		// if(hitSprites[spriteIndex]) {
			// Dealing with the brick, get the sprite renderer to change it to new sprite in array
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// TODO remove this method once we can actually win! 
	void SimulateWin() {
		levelManager.loadNextLevel();
		
	}
}
