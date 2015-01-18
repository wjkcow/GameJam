using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {

	public AudioClip NewMusic;
	private static GameMusic instance = null;
	public static GameMusic Instance 
	{
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) 
		{
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);

		GameObject go = GameObject.Find("Game Music"); //Finds the game object called Game Music, if it goes by a different name, change this. 
		go.audio.clip = NewMusic; 
		//Replaces the old audio with the new one set in the inspector. 
		go.audio.Play(); //Plays the audio.
	}
}
