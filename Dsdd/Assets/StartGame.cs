using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public void StartGame_level() {
		Application.LoadLevel("wjn_scene");
	}
	public void returnToTitle() {
		Application.LoadLevel ("_Title_Screen");
	}
}
