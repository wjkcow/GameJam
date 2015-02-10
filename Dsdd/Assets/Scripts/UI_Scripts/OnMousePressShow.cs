using UnityEngine;
using System.Collections;

public class OnMousePressShow : MonoBehaviour {

	private bool shown = false;
	public int sequence_id = 1;
	void Update() {

		if (Input.GetMouseButtonDown(1)) {
			if (!shown){
				StartCoroutine(showText());
			}
		}
	}
	IEnumerator showText() {
		while (true) {
			if (HelpTextControl.HelpTextindex != sequence_id) {
				yield return new WaitForSeconds(0.3f);
				continue;
			}
			Debug.Log("HELP TEXT: enter trigger, show text");
			GetComponentInParent<ShowHelpText>().showText();
			shown = true;
			HelpTextControl.incrementIndex(2.0f);
			shown = false;
			break;
		}

	}
}
