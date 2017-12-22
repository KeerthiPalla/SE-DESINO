using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class DPTestControl : MonoBehaviour {
	private static int score=0;
	private int scoreInt;
	public Text text1;
	public Text text2;
	public Button button;
	public Canvas menuCanvas;
	private GameObject menuCanvas1;
	public AudioSource source;
	//public AudioClip jumpSound;
	public AudioClip slipSound;
	private Animator anim;
	
	private string[] lines;
	private string score0;
	private string score1;
	private string score2;
	private string finalScore;

	public void playerInVisible(){
		menuCanvas.transform.GetChild (0).GetComponent<Image> ().canvasRenderer.SetAlpha (0.0f);
	}
	
	public void jump(){
		anim = menuCanvas.transform.GetChild (0).GetComponent<Animator> ();
		anim.SetInteger ("jump", 1);
	}
	public void fall(){
		anim = menuCanvas.transform.GetChild (0).GetComponent<Animator> ();
		anim.SetInteger ("jump", 0);
		source.PlayOneShot (slipSound);
	}



	public void rightAnswer(){
		score = score + 1;
		Debug.LogWarning (score);
	}
	
	public void fadeOut(CanvasGroup canvasGroup){
		StartCoroutine (doFadeOut (canvasGroup));
	}
	IEnumerator doFadeOut(CanvasGroup canvasGroup){
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;
		while (canvasGroup.alpha>0) {
			canvasGroup.alpha -= Time.deltaTime/2;
			yield return null;
		}
		
		yield return null;
	}
	public void fadeIn(CanvasGroup canvasGroup){
		StartCoroutine (doFadeIn (canvasGroup));
	}
	IEnumerator doFadeIn(CanvasGroup canvasGroup){
		while (canvasGroup.alpha<1) {
			canvasGroup.alpha += Time.deltaTime/2;
			yield return null;
		}
		canvasGroup.interactable = true;
		canvasGroup.blocksRaycasts = true;
		anim = menuCanvas.transform.GetChild (0).GetComponent<Animator> ();
		anim.SetInteger ("jump", 1);
		//source.clip = jumpSound;
		//source.Play ();
		yield return null;
	}
	
	//write a function to display score and save it if high
	public void getScore(){
		button.interactable = false;
		if (score < 21) {
			text1.text = "Do Better Next Time..";
			text2.text = score.ToString () + " Out of 40";
			menuCanvas.transform.GetChild (2).GetComponent<Image> ().canvasRenderer.SetAlpha (1.0f);
			menuCanvas.transform.GetChild (2).GetComponent<Animator> ().SetBool("low",true);
		} else if (score < 35) {
			text1.text = "Thats Better..";
			text2.text = score.ToString () + " Out of 40";
			menuCanvas.transform.GetChild (1).GetComponent<Image> ().canvasRenderer.SetAlpha (1.0f);
			menuCanvas.transform.GetChild (1).GetComponent<Animator> ().SetBool("medium",true);
		} else if (score < 41) {
			text1.text = "Excellent..";
			text2.text = score.ToString () + " Out of 40";
			menuCanvas.transform.GetChild (3).GetComponent<Image> ().canvasRenderer.SetAlpha (1.0f);
			menuCanvas.transform.GetChild (3).GetComponent<Animator> ().SetBool("high",true);
		}
		if (System.IO.File.Exists (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "Score.txt")) {
			lines = System.IO.File.ReadAllLines (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "Score.txt");
			foreach (char c in lines[1])
				score1 += c.ToString ();
			scoreInt = int.Parse (score1);
			if (scoreInt < score) {
				foreach (char c in lines[0])
					score0 += c.ToString ();
				foreach (char c in lines[2])
					score2 += c.ToString ();
				finalScore = score0+Environment.NewLine+score.ToString()+Environment.NewLine+score2;
				
				System.IO.File.WriteAllText (@"E:\SEDesinoUserData\" + PlayerPrefs.GetString ("LoggedInAs") + "Score.txt", finalScore);
			}
			
		}
	}
	// Use this for initialization
	void Start () {
		menuCanvas1 = GameObject.Find ("MenuCanvas");
		menuCanvas1.transform.GetChild (2).GetComponent<Image> ().canvasRenderer.SetAlpha (0.0f);
		menuCanvas1.transform.GetChild (1).GetComponent<Image> ().canvasRenderer.SetAlpha (0.0f);
		menuCanvas1.transform.GetChild (3).GetComponent<Image> ().canvasRenderer.SetAlpha (0.0f);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
