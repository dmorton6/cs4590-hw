using UnityEngine;
using System.Collections;

public class movingEasterEggIndicator : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	   gameObject.transform.position += new Vector3(0, 0, -0.1f);
		
	   if (gameObject.transform.position.z < -240) {
			// mute, because we have hit the Easter egg
			gameObject.audio.volume = 0;
		}
	}
}
