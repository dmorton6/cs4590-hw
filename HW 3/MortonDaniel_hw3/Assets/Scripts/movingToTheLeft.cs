using UnityEngine;
using System.Collections;

public class movingToTheLeft : MonoBehaviour {

	string direction;
	Vector3 right = new Vector3(0, 0, 0.05f);
	int rightBound = 35;
	int leftBound = 25;
	
	// Use this for initialization
	void Start () {
	    direction = "right";
	}
	
	// Update is called once per frame
	void Update () {
		
		if (direction.Equals("right")) {		
			if (gameObject.transform.position.z < rightBound) {
				// keep going to the right
				gameObject.transform.position += right;
			} 
			else {
				// move back to the left
				direction = "left";
				gameObject.transform.position -= right;
			}
		}	
		else { 
			if (gameObject.transform.position.z > leftBound) {
				// keep going to the left
				gameObject.transform.position -= right;
			}
			else {
				// move back to the right
				direction = "right";
				gameObject.transform.position += right;
			}
		}
	}
}