using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public AudioSource BGM;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		if (FindObjectsOfType<AudioManager> ().Length > 1)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
