using UnityEngine;
using System.Collections;

public class CharacterPusher : MonoBehaviour {
	
	public float pushPower = 2.0F;
	System.Random rand = new System.Random();

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
    void OnControllerColliderHit(ControllerColliderHit hit) {
		
        Rigidbody body = hit.collider.attachedRigidbody;
		
		//don't push things that are Kinematic or have no rigid body
        if (body == null || body.isKinematic)
            return;
        
		//if hitting from above, don't play the sound
        if (hit.moveDirection.y < -0.3F)
            return;
        
		
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
		
		if (body.position.z.Equals(-240)) {
			// -240 is the wall behind the pond
			if (!body.audio.isPlaying) body.audio.Play(); // play sound if it's not already playing
		}
		else if (body.position.z.Equals(129)) {
			// refrigerator opening
			if (!body.audio.isPlaying) body.audio.Play(); // play sound if it's not already playing
		}
		else if (body.position.z.Equals(0)) {
			// jukebox - attempt
			
			
			int randSong = rand.Next(0,4); // a random number between 0 and 3
			int freq1 = 220;
			int freq2 = 2*freq1; //etc
			int freq3 = 2*freq2;
			int freq4 = 2*freq3;
			int fs = 44100;

			if (hit.moveLength > 0.1) {
				
				switch(randSong) {
				case 0:
					body.audio.clip = AudioClip.Create("sine0", fs, 1, fs, true, true);
					Debug.Log ("making the " + freq1 + " Hz sine wave");
					break;
				case 1:
					body.audio.clip = AudioClip.Create("sine1", fs, 1, fs, true, true);
					Debug.Log ("making the " + freq2 + " Hz sine wave");
					break;
				case 2:
					body.audio.clip = AudioClip.Create("sine2", fs, 1, fs, true, true);
					Debug.Log ("making the " + freq3 + " Hz sine wave");
					break;
				case 3:
					body.audio.clip = AudioClip.Create("sine3", fs, 1, fs, true, true);
					Debug.Log ("making the " + freq4 + " Hz sine wave");
					break;
				}
			body.audio.Play();
			}
		
			
		}
    }
}
