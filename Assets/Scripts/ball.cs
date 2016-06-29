using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	
	// Will link the paddle to the ball:
	private paddle paddle; 
	// Distance between paddle and ball:
	private Vector3 paddleToBallVector;
	// Game state:
	private bool started = false; 
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<paddle>();
		paddleToBallVector = this.transform.position  - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (started == false) {
			// Make the ball stay on the paddle every frame (Ball stays relative to the paddle)
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			// Send the ball flying when the mouse has been clicked
			if(Input.GetMouseButtonDown(0)) {
				print ("Mouse button has been clicked");
				started = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
		
	}
}
