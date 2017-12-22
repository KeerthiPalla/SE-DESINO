using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using System.IO;
public class UMLLoadLevel : MonoBehaviour {
	public Canvas canvas;
	public Sprite []newSprite;
	private string[] lines;
	private string level="";
	private int levelNumber;
	public void level1Clicked()
	{
		Application.LoadLevel ("UMLlevel1");
	}
	public void level2Clicked()
	{
		Application.LoadLevel ("UMLlevel2");
	}
	public void level3Clicked()
	{
		Application.LoadLevel ("UMLlevel3");
	}
	public void level4Clicked()
	{
		Application.LoadLevel ("UMLlevel4");
	}
	public void level5Clicked()
	{
		Application.LoadLevel ("UMLlevel5");
	}
	public void level6Clicked()
	{
		Application.LoadLevel ("UMLlevel6");
	}
	public void level7Clicked()
	{
		Application.LoadLevel ("UMLlevel7");
	}
	public void level8Clicked()
	{
		Application.LoadLevel ("UMLlevel8");
	}
	public void level9Clicked()
	{
		Application.LoadLevel ("UMLlevel9");
	}
	public void level10Clicked()
	{
		Application.LoadLevel ("UMLlevel10");
	}
	public void level11Clicked()
	{
		Application.LoadLevel ("UMLlevel11");
	}
	public void level12Clicked()
	{
		Application.LoadLevel ("UMLlevel12");
	}
	public void level13Clicked()
	{
		Application.LoadLevel ("UMLlevel13");
	}
	public void previousClicked(){
		Application.LoadLevel ("Play");
	}
	// Use this for initialization
	void Start () {
		
		
		if (System.IO.File.Exists (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "UML.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "UML.txt");
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
