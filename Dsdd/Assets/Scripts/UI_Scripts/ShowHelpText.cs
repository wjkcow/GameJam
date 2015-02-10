using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowHelpText : ShowAndFade {
	void Start() {
		text = GetComponent<Text> ();
		curColor = text.color;
		resetColor ();
	}
	public void showText() {
		StartCoroutine (showAndFade (2.0f));
	}

}
