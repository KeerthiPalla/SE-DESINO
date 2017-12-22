using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;


public class Henrun : MonoBehaviour {
	public Animator anim;
	public AudioSource source;
	public AudioClip clip;


	IEnumerator henRun(){
		yield return new WaitForSeconds (3);
		anim.SetBool ("henrun", true);
		source.PlayOneShot (clip);
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (henRun ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
