using UnityEngine;
using System.Collections;

public class LoadSubject : MonoBehaviour {

	public void redButtonClicked(){
		Application.LoadLevel ("CC");
	}
	public void blackButtonClicked(){
		Application.LoadLevel ("DP");
	}
	public void purpleButtonClicked(){
		Application.LoadLevel ("UML");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
