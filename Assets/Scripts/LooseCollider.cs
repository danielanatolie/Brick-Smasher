using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	private LevelManager levelManger;
	
	void OnTriggerEnter2D(Collider2D trigger) {
		levelManger = GameObject.FindObjectOfType<LevelManager>();
		print ("Trigger");
		levelManger.LoadLevel("Lose");
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		print ("Collision");
	}
}
