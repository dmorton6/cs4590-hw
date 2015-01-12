#pragma strict

// This JavaScript file is used to hide or show obejcts based on keypresses
// The file is applied to all objects in the scene to make them all be hidden at once

function Update() {		

	if (Input.GetKeyDown(KeyCode.Semicolon)) {
	    renderer.enabled = false;
	}
	
	if (Input.GetKeyDown(KeyCode.Period)) {
		renderer.enabled = true;
	}
}
