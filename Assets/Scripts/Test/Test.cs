using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Test : MonoBehaviour {

	public void quickTestClicked(){
		Application.LoadLevel ("TestScreen");
		GameObject.Find ("Sound").transform.GetChild (0).GetComponent<CanvasGroup> ().alpha=0f;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
