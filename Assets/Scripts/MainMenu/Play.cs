using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {


	public void play()
	{
				Application.LoadLevel ("Play");
		GameObject.Find ("Sound").transform.GetChild (0).GetComponent<CanvasGroup> ().alpha=0f;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
