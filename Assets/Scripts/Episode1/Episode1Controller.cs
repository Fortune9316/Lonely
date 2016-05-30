using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class Episode1Controller : MonoBehaviour {

	// Use this for initialization
	public MovieTexture movie;
	private AudioSource audioS;
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		audioS = GetComponent<AudioSource>();
		audioS.clip = movie.audioClip;
		movie.Play();
		audioS.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
