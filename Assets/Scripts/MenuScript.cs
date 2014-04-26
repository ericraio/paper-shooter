using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	private const int buttonWidth = 84;
	private const int buttonHeight = 60;

	private GUISkin skin;


	void OnGUI() {
		Rect guiContent = buildGUIContent();

		// Draw a button to start the game
		if(GUI.Button(guiContent, "Start!")) {
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Stage1");
		}
	}

	private Rect buildGUIContent() {

		int positionX = Screen.width / 2 - (buttonWidth / 2);
		int positionY = 2 * Screen.height / 3 - (buttonHeight / 2 );

		return new Rect(positionX, positionY, buttonWidth, buttonHeight);
	}

}