using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		if (FindObjectsOfType<Sound> ().Length>1)
			Destroy (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
