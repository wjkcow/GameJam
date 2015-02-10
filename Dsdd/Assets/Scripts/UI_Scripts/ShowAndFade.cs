using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShowAndFade : MonoBehaviour {
	public Text text;
	private float alpha = 1.0f;
	private float fadeRate = 0.1f;
	public Color curColor;
	// Use this for initialization
	public void Start () {
		text = GetComponent<Text> ();
		curColor = text.color;
		StartCoroutine (showAndFade (0.5f));

	}
	public void resetColor () {
		text.color = new Color(0, 0, 0, 0);
	}
	public IEnumerator showAndFade(float lingerlength) {

		text.color = new Color(0, 0, 0, 0);
		for (float i = 0.0f; i < 1.0f; i+= fadeRate) {
			text.color = new Color(curColor.r,
			                       curColor.g,
			                       curColor.b,
			                       i);
			yield return new WaitForSeconds (0.1f);;
		}
		yield return new WaitForSeconds (lingerlength);
		for (float i = 0.0f; i < 1.0f; i+= fadeRate) {
			text.color = new Color(curColor.r,
			                       curColor.g,
			                       curColor.b,
			                       1.0f - i);
			yield return new WaitForSeconds (0.1f);;
		}
		text.color = new Color(0, 0, 0, 0);
	}
	

}
