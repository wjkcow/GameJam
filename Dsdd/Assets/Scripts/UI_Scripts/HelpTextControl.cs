using UnityEngine;
using System.Collections;

public class HelpTextControl : MonoBehaviour {
	static public HelpTextControl instance;
	void Awake() {
		instance = this;
	}

	public static int helpTextindex = 0;
	public static int HelpTextindex
	{
		get {return helpTextindex;}
	}

	public static void incrementIndex(float waitForSeconds) {
		instance.StartCoroutine (increment(waitForSeconds));
	}

	private static IEnumerator increment(float waitForSeconds) {
		yield return new WaitForSeconds (waitForSeconds);
		helpTextindex++;
	}
}
