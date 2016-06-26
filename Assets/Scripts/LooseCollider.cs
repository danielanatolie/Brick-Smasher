using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManger;
	
	void OnTriggerEnter2D(Collider2D trigger) {
		print ("Trigger");
		levelManger.LoadLevel("Win");
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		print ("Collision");
	}
}
