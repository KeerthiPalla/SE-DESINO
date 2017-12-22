using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
public class LoadPlayer : MonoBehaviour {

	public Text setName;
	// Use this for initialization
	void Start () {
		setName.text = PlayerPrefs.GetString ("LoggedInAs");

	}
	
	// Update is called once per frame
	void Update () {


	}
}
