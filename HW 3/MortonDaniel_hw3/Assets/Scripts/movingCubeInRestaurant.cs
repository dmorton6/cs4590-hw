using UnityEngine;
using System.Collections;

public class movingCubeInRestaurant : MonoBehaviour {

	string direction;
	Vector3 right = new Vector3(0.05f, 0, 0);
	int rightBound = 20;
	int leftBound = -20;
	
	// Use this for initialization
	void Start () {
	    direction = "right";
	}
	
	// Update is called once per frame
	void Update () {
		
		if (direction.Equals("right")) {		
			if (gameObject.transform.position.x < rightBound) {
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
			if (gameObject.transform.position.x > leftBound) {
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