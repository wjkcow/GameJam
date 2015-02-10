using UnityEngine;
using System.Collections;

public class OnTriggerEnterShowText : MonoBehaviour {
	private bool shown = false;
	public int sequence_id = 2;
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("HELP TEXT: enter trigger, show text");
		if (!shown && other.tag == "Player" && 
		    HelpTextControl.HelpTextindex == sequence_id){
			GetComponentInParent<ShowHelpText>().showText();
			shown = true;

			HelpTextControl.incrementIndex(2.0f);
		}
	}
	

}
