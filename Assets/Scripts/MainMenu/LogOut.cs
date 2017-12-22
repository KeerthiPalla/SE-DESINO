using UnityEngine;
using System.Collections;
using System.IO;

public class LogOut : MonoBehaviour {


	public void logOut()
	{
		Destroy (GameObject.Find("AudioManager(Clone)"));
		 Destroy (GameObject.Find ("AudioManager"));
		Destroy (GameObject.Find ("Sound"));
		System.IO.File.Copy (@"E:\SEDesinoUserData\CC.txt",@"E:\SEDesinoUserData\"+PlayerPrefs.GetString ("LoggedInAs")+"CC.txt",true);
		System.IO.File.Copy (@"E:\SEDesinoUserData\DP.txt",@"E:\SEDesinoUserData\"+PlayerPrefs.GetString ("LoggedInAs")+"DP.txt",true);
		System.IO.File.Copy (@"E:\SEDesinoUserData\UML.txt",@"E:\SEDesinoUserData\"+PlayerPrefs.GetString ("LoggedInAs")+"UML.txt",true);
		System.IO.File.Copy (@"E:\SEDesinoUserData\Score.txt",@"E:\SEDesinoUserData\"+PlayerPrefs.GetString ("LoggedInAs")+"Score.txt",true);
		PlayerPrefs.SetString ("LoggedInAs", "");
		Application.LoadLevel ("LoginSystem");
	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
