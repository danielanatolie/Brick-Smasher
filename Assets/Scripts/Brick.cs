using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	
	private int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		print ("Collisided with 1 hit brick");
		timesHit++; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
