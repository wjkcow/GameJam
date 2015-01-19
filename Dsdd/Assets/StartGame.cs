
using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public void go_helpScreen () {
		Application.LoadLevel ("_Help_Scene");
	}
	public void StartGame_level() {
		Application.LoadLevel("tutorial_scene_portal");
	}
	public void returnToTitle() {
		Application.LoadLevel ("_Title_Screen");
	}
}
