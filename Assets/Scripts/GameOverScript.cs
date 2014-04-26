using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	private const int buttonWidth = 120;
	private const int buttonHeight = 60;

	private GUISkin skin;

	void OnGUI() {
		Rect retryGUIContent = buildGUIContent(1);
		Rect menuGUIContent = buildGUIContent(2);

		if(GUI.Button(retryGUIContent, "Retry!")) {
			// Reload the level
			Application.LoadLevel("Stage1");
		}

		if(GUI.Button(menuGUIContent, "Back To Menu")) {
			// Return to Menu
			Application.LoadLevel("Menu");
		}
	}

	private Rect buildGUIContent(int position) {
			int positionX = (Screen.width / 2) - (buttonWidth / 2);
			int positionY = (position * Screen.height / 3) - (buttonHeight / 2);
			return new Rect(positionX, positionY, buttonWidth, buttonHeight);
	}
}
