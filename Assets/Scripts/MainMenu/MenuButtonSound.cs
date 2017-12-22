using UnityEngine;
using System.Collections;

public class MenuButtonSound : MonoBehaviour {

	public AudioSource source;
	public AudioClip hover;

	public void onHover()
	{
		source.PlayOneShot (hover);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
