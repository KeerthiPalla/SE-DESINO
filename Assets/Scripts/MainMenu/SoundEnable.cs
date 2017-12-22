using UnityEngine;
using System.Collections;

public class SoundEnable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Sound").transform.GetChild (0).GetComponent<CanvasGroup> ().alpha=1f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
