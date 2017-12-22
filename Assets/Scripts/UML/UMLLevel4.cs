﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class UMLLevel4 : MonoBehaviour {
	private string playerName;
	private string[] lines;
	private string level;
	private int levelNumber;
	public CanvasGroup canvas;
	public CanvasGroup canvas1;
	public CanvasGroup canvas2;
	public CanvasGroup canvas3;
	public CanvasGroup canvas4;
	public CanvasGroup canvas5;
	public CanvasGroup canvas6;
	public CanvasGroup canvas7;
	public CanvasGroup canvas8;
	public CanvasGroup canvas9;
	public CanvasGroup canvas10;
	public CanvasGroup canvas11;
	public CanvasGroup canvas12;
	public CanvasGroup canvas13;
	public CanvasGroup canvas14;
	public CanvasGroup canvas15;
	public CanvasGroup canvas16;
	public CanvasGroup canvas17;
	public CanvasGroup canvas18;
	public CanvasGroup canvas19;
	
	
	
	public void canvasNext (){
		canvas.alpha = 0f;
		canvas.interactable = false;
		canvas.blocksRaycasts = false;
		canvas1.alpha = 1f;
		canvas1.interactable = true;
		canvas1.blocksRaycasts = true;
	}
	public void canvasPrevious(){
		Application.LoadLevel ("UML");
	}
	public void canvas1Next (){
		canvas1.alpha = 0f;
		canvas1.interactable = false;
		canvas1.blocksRaycasts = false;
		canvas2.alpha = 1f;
		canvas2.interactable = true;
		canvas2.blocksRaycasts = true;
	}
	public void canvas1Previous (){
		canvas1.alpha = 0f;
		canvas1.interactable = false;
		canvas1.blocksRaycasts = false;
		canvas.alpha = 1f;
		canvas.interactable = true;
		canvas.blocksRaycasts = true;
	}
	public void canvas2Next (){
		canvas2.alpha = 0f;
		canvas2.interactable = false;
		canvas2.blocksRaycasts = false;
		canvas3.alpha = 1f;
		canvas3.interactable = true;
		canvas3.blocksRaycasts = true;
	}
	public void canvas2Previous (){
		canvas2.alpha = 0f;
		canvas2.interactable = false;
		canvas2.blocksRaycasts = false;
		canvas1.alpha = 1f;
		canvas1.interactable = true;
		canvas1.blocksRaycasts = true;
	}
	public void canvas3Next (){
		canvas3.alpha = 0f;
		canvas3.interactable = false;
		canvas3.blocksRaycasts = false;
		canvas4.alpha = 1f;
		canvas4.interactable = true;
		canvas4.blocksRaycasts = true;
	}
	public void canvas3Previous (){
		canvas3.alpha = 0f;
		canvas3.interactable = false;
		canvas3.blocksRaycasts = false;
		canvas2.alpha = 1f;
		canvas2.interactable = true;
		canvas2.blocksRaycasts = true;
	}
	public void canvas4Next (){
		canvas4.alpha = 0f;
		canvas4.interactable = false;
		canvas4.blocksRaycasts = false;
		canvas5.alpha = 1f;
		canvas5.interactable = true;
		canvas5.blocksRaycasts = true;
	}
	public void canvas4Previous (){
		canvas4.alpha = 0f;
		canvas4.interactable = false;
		canvas4.blocksRaycasts = false;
		canvas3.alpha = 1f;
		canvas3.interactable = true;
		canvas3.blocksRaycasts = true;
	}
	public void canvas5Next (){
		canvas5.alpha = 0f;
		canvas5.interactable = false;
		canvas5.blocksRaycasts = false;
		canvas6.alpha = 1f;
		canvas6.interactable = true;
		canvas6.blocksRaycasts = true;
	}
	public void canvas5Previous (){
		canvas5.alpha = 0f;
		canvas5.interactable = false;
		canvas5.blocksRaycasts = false;
		canvas4.alpha = 1f;
		canvas4.interactable = true;
		canvas4.blocksRaycasts = true;
	}
	public void canvas6Next (){
		canvas6.alpha = 0f;
		canvas6.interactable = false;
		canvas6.blocksRaycasts = false;
		canvas7.alpha = 1f;
		canvas7.interactable = true;
		canvas7.blocksRaycasts = true;
	}
	public void canvas6Previous (){
		canvas6.alpha = 0f;
		canvas6.interactable = false;
		canvas6.blocksRaycasts = false;
		canvas5.alpha = 1f;
		canvas5.interactable = true;
		canvas5.blocksRaycasts = true;
	}
	
	public void canvas7Next (){
		canvas7.alpha = 0f;
		canvas7.interactable = false;
		canvas7.blocksRaycasts = false;
		canvas8.alpha = 1f;
		canvas8.interactable = true;
		canvas8.blocksRaycasts = true;
	}
	public void canvas7Previous (){
		canvas7.alpha = 0f;
		canvas7.interactable = false;
		canvas7.blocksRaycasts = false;
		canvas6.alpha = 1f;
		canvas6.interactable = true;
		canvas6.blocksRaycasts = true;
	}
	public void canvas8Next (){
		canvas8.alpha = 0f;
		canvas8.interactable = false;
		canvas8.blocksRaycasts = false;
		canvas9.alpha = 1f;
		canvas9.interactable = true;
		canvas9.blocksRaycasts = true;
	}
	public void canvas8Previous (){
		canvas8.alpha = 0f;
		canvas8.interactable = false;
		canvas8.blocksRaycasts = false;
		canvas7.alpha = 1f;
		canvas7.interactable = true;
		canvas7.blocksRaycasts = true;
	}
	public void canvas9Next (){
		canvas9.alpha = 0f;
		canvas9.interactable = false;
		canvas9.blocksRaycasts = false;
		canvas10.alpha = 1f;
		canvas10.interactable = true;
		canvas10.blocksRaycasts = true;
	}
	public void canvas9Previous (){
		canvas9.alpha = 0f;
		canvas9.interactable = false;
		canvas9.blocksRaycasts = false;
		canvas8.alpha = 1f;
		canvas8.interactable = true;
		canvas8.blocksRaycasts = true;
	}
	public void canvas10Next (){
		canvas10.alpha = 0f;
		canvas10.interactable = false;
		canvas10.blocksRaycasts = false;
		canvas11.alpha = 1f;
		canvas11.interactable = true;
		canvas11.blocksRaycasts = true;
	}
	public void canvas10Previous (){
		canvas10.alpha = 0f;
		canvas10.interactable = false;
		canvas10.blocksRaycasts = false;
		canvas9.alpha = 1f;
		canvas9.interactable = true;
		canvas9.blocksRaycasts = true;
	}
	public void canvas11Next (){
		canvas11.alpha = 0f;
		canvas11.interactable = false;
		canvas11.blocksRaycasts = false;
		canvas12.alpha = 1f;
		canvas12.interactable = true;
		canvas12.blocksRaycasts = true;
	}
	public void canvas11Previous (){
		canvas11.alpha = 0f;
		canvas11.interactable = false;
		canvas11.blocksRaycasts = false;
		canvas10.alpha = 1f;
		canvas10.interactable = true;
		canvas10.blocksRaycasts = true;
	}
	public void canvas12Next (){
		canvas12.alpha = 0f;
		canvas12.interactable = false;
		canvas12.blocksRaycasts = false;
		canvas13.alpha = 1f;
		canvas13.interactable = true;
		canvas13.blocksRaycasts = true;
	}
	public void canvas12Previous (){
		canvas12.alpha = 0f;
		canvas12.interactable = false;
		canvas12.blocksRaycasts = false;
		canvas11.alpha = 1f;
		canvas11.interactable = true;
		canvas11.blocksRaycasts = true;
	}
	public void canvas13Next (){
		canvas13.alpha = 0f;
		canvas13.interactable = false;
		canvas13.blocksRaycasts = false;
		canvas14.alpha = 1f;
		canvas14.interactable = true;
		canvas14.blocksRaycasts = true;
	}
	public void canvas13Previous (){
		canvas13.alpha = 0f;
		canvas13.interactable = false;
		canvas13.blocksRaycasts = false;
		canvas11.alpha = 1f;
		canvas11.interactable = true;
		canvas11.blocksRaycasts = true;
	}
	public void canvas14Next (){
		canvas14.alpha = 0f;
		canvas14.interactable = false;
		canvas14.blocksRaycasts = false;
		canvas15.alpha = 1f;
		canvas15.interactable = true;
		canvas15.blocksRaycasts = true;
	}
	public void canvas14Previous (){
		canvas14.alpha = 0f;
		canvas14.interactable = false;
		canvas14.blocksRaycasts = false;
		canvas13.alpha = 1f;
		canvas13.interactable = true;
		canvas13.blocksRaycasts = true;
	}
	public void canvas15Next (){
		canvas15.alpha = 0f;
		canvas15.interactable = false;
		canvas15.blocksRaycasts = false;
		canvas16.alpha = 1f;
		canvas16.interactable = true;
		canvas16.blocksRaycasts = true;
	}
	public void canvas15Previous (){
		canvas15.alpha = 0f;
		canvas15.interactable = false;
		canvas15.blocksRaycasts = false;
		canvas14.alpha = 1f;
		canvas14.interactable = true;
		canvas14.blocksRaycasts = true;
	}
	public void canvas16Next (){
		canvas16.alpha = 0f;
		canvas16.interactable = false;
		canvas16.blocksRaycasts = false;
		canvas17.alpha = 1f;
		canvas17.interactable = true;
		canvas17.blocksRaycasts = true;
	}
	public void canvas16Previous (){
		canvas16.alpha = 0f;
		canvas16.interactable = false;
		canvas16.blocksRaycasts = false;
		canvas15.alpha = 1f;
		canvas15.interactable = true;
		canvas15.blocksRaycasts = true;
	}
	public void canvas17Next (){
		canvas17.alpha = 0f;
		canvas17.interactable = false;
		canvas17.blocksRaycasts = false;
		canvas18.alpha = 1f;
		canvas18.interactable = true;
		canvas18.blocksRaycasts = true;
	}
	public void canvas17Previous (){
		canvas17.alpha = 0f;
		canvas17.interactable = false;
		canvas17.blocksRaycasts = false;
		canvas16.alpha = 1f;
		canvas16.interactable = true;
		canvas16.blocksRaycasts = true;
	}
	public void canvas18Next (){
		canvas18.alpha = 0f;
		canvas18.interactable = false;
		canvas18.blocksRaycasts = false;
		canvas19.alpha = 1f;
		canvas19.interactable = true;
		canvas19.blocksRaycasts = true;
	}
	public void canvas18Previous (){
		canvas18.alpha = 0f;
		canvas18.interactable = false;
		canvas18.blocksRaycasts = false;
		canvas17.alpha = 1f;
		canvas17.interactable = true;
		canvas17.blocksRaycasts = true;
	}

	public void canvas19Next (){
		playerName = PlayerPrefs.GetString ("LoggedInAs");
		if (System.IO.File.Exists (@"E:\SEDesinoUserData\"+playerName+"UML.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\"+playerName+"UML.txt");
			foreach (char c in lines[0])
				level += c.ToString ();
			levelNumber = int.Parse (level);
			if(levelNumber<4)
				System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+playerName+"UML.txt","4" );
		}
		else{
			//System.IO.File.Create(@"E:\SEDesinoUserData\UML.txt");
			System.IO.File.Create(@"E:\SEDesinoUserData\"+playerName+"UML.txt").Close();
			System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+playerName+"UML.txt","4" );
			Debug.LogWarning("File Created");
		}
		Application.LoadLevel ("UML");
	}
	public void canvas19Previous (){
		canvas19.alpha = 0f;
		canvas19.interactable = false;
		canvas19.blocksRaycasts = false;
		canvas18.alpha = 1f;
		canvas18.interactable = true;
		canvas18.blocksRaycasts = true;
	}
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}