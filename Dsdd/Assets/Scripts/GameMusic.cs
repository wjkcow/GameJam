using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {

	private static GameMusic instance = null;
//	public int lifeTime;
//	private static int instCount = 0;
	public static GameMusic Instance 
	{
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this)// && instCount < lifeTime) 
		{
//			instCount++;
			Destroy(instance.gameObject);
		}
		instance = this;
		DontDestroyOnLoad(this.gameObject);
//		if (instCount >= lifeTime) 
//		{
//			Debug.Log ("destroyed");
//			this.audio.mute = true;
//			this.audio.Stop();
//			Destroy(this.gameObject);
//		}
//		Debug.Log ("life = " + instCount);

	}
}
