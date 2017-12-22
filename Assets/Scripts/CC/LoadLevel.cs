using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using System.IO;
public class LoadLevel : MonoBehaviour {
	public Canvas canvas;
	public Sprite []newSprite;
	private string[] lines;
	private string level="";
	private int levelNumber;
	public void level1Clicked()
	{
		Application.LoadLevel ("CClevel1");
	}
	public void level2Clicked()
	{
		Application.LoadLevel ("CClevel2");
	}
	public void level3Clicked()
	{
		Application.LoadLevel ("CClevel3");
	}
	public void level4Clicked()
	{
		Application.LoadLevel ("CClevel4");
	}
	public void previousClicked(){
		Application.LoadLevel ("Play");
	}
	// Use this for initialization
	void Start () {


		if (System.IO.File.Exists (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "CC.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "CC.txt");
			foreach (char c in lines[0])
				level += c.ToString ();
			levelNumber = int.Parse (level);
			for (int i=0; i<levelNumber; i++) {
				canvas.transform.GetChild (i).GetComponent<Button> ().image.overrideSprite = newSprite [i];
				canvas.transform.GetChild (i).GetComponent<Button> ().interactable=true;
			}
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
