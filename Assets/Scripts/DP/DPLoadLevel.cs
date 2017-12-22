using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using System.IO;
public class DPLoadLevel : MonoBehaviour {
	public Canvas canvas;
	public Sprite []newSprite;
	private string[] lines;
	private string level="";
	private int levelNumber;
	public void level1Clicked()
	{
		Application.LoadLevel ("DPlevel1");
	}
	public void level2Clicked()
	{
		Application.LoadLevel ("DPlevel2");
	}
	public void level3Clicked()
	{
		Application.LoadLevel ("DPlevel3");
	}
	public void level4Clicked()
	{
		Application.LoadLevel ("DPlevel4");
	}
	public void level5Clicked()
	{
		Application.LoadLevel ("DPlevel5");
	}
	public void level6Clicked()
	{
		Application.LoadLevel ("DPlevel6");
	}
	public void level7Clicked()
	{
		Application.LoadLevel ("DPlevel7");
	}
	public void level8Clicked()
	{
		Application.LoadLevel ("DPlevel8");
	}
	public void level9Clicked()
	{
		Application.LoadLevel ("DPlevel9");
	}
	public void level10Clicked()
	{
		Application.LoadLevel ("DPlevel10");
	}
	public void level11Clicked()
	{
		Application.LoadLevel ("DPlevel11");
	}
	public void level12Clicked()
	{
		Application.LoadLevel ("DPlevel12");
	}
	public void level13Clicked()
	{
		Application.LoadLevel ("DPlevel13");
	}
	public void level14Clicked()
	{
		Application.LoadLevel ("DPlevel14");
	}
	public void level15Clicked()
	{
		Application.LoadLevel ("DPlevel15");
	}
	public void previousClicked(){
		Application.LoadLevel ("Play");
	}
	// Use this for initialization
	void Start () {
		
		
		if (System.IO.File.Exists (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "DP.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "DP.txt");
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
