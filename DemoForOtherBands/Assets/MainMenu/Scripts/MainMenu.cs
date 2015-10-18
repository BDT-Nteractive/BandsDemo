using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	// The texture for the background that we need to display.
	public Texture backgroundTexture;

	public float guiPlacementY1;
	public float guiPlacementY2;

	public float guiPlacementX1;
	public float guiPlacementX2;
	
	public bool isClicked;

	
	void OnGUI() {
		// Display our background texture.
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
		
		// Displays our button that's pressable.
		// X @ quarter of the screen.
		// Y @ half of screen.
		// Note: Due to those playing the game on different resolutions, it is more efficient to use multiplication
		// 		based on the screen width/height instead of adding/subtracting a set amount.
		if (GUI.Button(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Play Game")) {
			isClicked = true;
		}

		if (GUI.Button(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Quit")) {
			isClicked = false;
		}
	}
}
