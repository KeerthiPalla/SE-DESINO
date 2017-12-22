using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class UMLLevel13 : MonoBehaviour {
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
	
	
	

	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
