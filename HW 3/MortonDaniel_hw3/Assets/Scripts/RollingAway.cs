using UnityEngine;
using System.Collections;

public class RollingAway : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject
		//gets access to the object this script is attached to
		
		//transform
		//contains position, scaling, rotation, etc
		
		if (gameObject.transform.position.x < 20) {
			gameObject.transform.position += new Vector3(0.01f, 0, 0.03f);
		}
		
	}
	
}
