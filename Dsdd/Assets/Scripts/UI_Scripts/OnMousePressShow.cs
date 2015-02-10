using UnityEngine;
using System.Collections;

public class OnMousePressShow : MonoBehaviour {

	private bool shown = false;
	
	void Update() {

		if (Input.GetMouseButtonDown(1)) {
			if (!shown && HelpTextControl.HelpTextindex == 1){
				Debug.Log("HELP TEXT: enter trigger, show text");
				GetComponentInParent<ShowHelpText>().showText();
				shown = true;
				HelpTextControl.incrementIndex(2.0f);
			}
		}
	}
}
