using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	public bool autoPlay = false; 
	public float minValue, maxValue;
	private ball ball;
	
	void Start() {
		ball = GameObject.FindObjectOfType<ball>();
	}
	
	void Update() {
		if(!autoPlay) {
			MoveWithMouse();
		} else {
			AutoPlay();
		}
	}
	
	void MoveWithMouse() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y , 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, minValue, maxValue);
		this.transform.position = paddlePos;
	}
	
	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y , 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp (ballPos.x, minValue, maxValue);
		this.transform.position = paddlePos;
	}
}
