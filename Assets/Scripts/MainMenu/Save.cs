using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Save : MonoBehaviour {
	//private string playerName;
	public Text setText;

	/*IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time);

		setText.text = "";
		// Code to execute after the delay
	}
	*/
	public void save(){
		//playerName = PlayerPrefs.GetString ("LoggedInAs");
		System.IO.File.Copy (@"E:\SEDesinoUserData\"+PlayerPrefs.GetString ("LoggedInAs")+"CC.txt",@"E:\SEDesinoUserData\CC.txt",true);
		setText.text = "Saved Successfully";
		//ExecuteAfterTime(2);


		//System.IO.File.Delete (@"E:\SEDesinoUserData\CC.txt");
		System.IO.File.Copy (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAS") + "DP.txt", @"E:\SEDesinoUserData\DP.txt",true);
		System.IO.File.Copy (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAS") + "UML.txt",@"E:\SEDesinoUserData\UML.txt",true);
		System.IO.File.Copy (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAS") + "Score.txt",@"E:\SEDesinoUserData\Score.txt",true);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
