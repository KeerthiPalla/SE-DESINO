using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class LoadTest : MonoBehaviour {
	public Text CCScore;
	public Text DPScore;
	public Text UMLScore;
	private string[] lines;
	private string scoreCC;
	private string scoreDP;
	private string scoreUML;
	public void ccTestClicked(){
		Application.LoadLevel ("CCTest");
	}
	public void dpTestClicked(){
		Application.LoadLevel ("DPTest");
	}
	public void umlTestClicked(){
		Application.LoadLevel ("UMLTest");
	}
	// Use this for initialization
	void Start () {
		if (System.IO.File.Exists (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "Score.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "Score.txt");
			foreach (char c in lines[0])
				scoreCC += c.ToString ();
			foreach (char c in lines[1])
				scoreDP += c.ToString ();
			foreach (char c in lines[2])
				scoreUML += c.ToString ();
			CCScore.text="Score :"+scoreCC+"/20";
			DPScore.text="Score :"+scoreDP+"/40";
			UMLScore.text="Score :"+scoreUML+"/20";

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
