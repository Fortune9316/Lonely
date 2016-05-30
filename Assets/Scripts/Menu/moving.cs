using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {
	//GameObject fog;
	AudioSource audioM;
	public Renderer rend;
	private float alpha;
	private Color color;
	GameObject fog;
	public GameObject[] hoja;


	void Start () 
	{
		//fog = this.gameObject;
		fog=this.gameObject;
		audioM = gameObject.AddComponent<AudioSource>() as AudioSource;
		audioM.clip = Microphone.Start("Micrófono", true, 1, 44100);
		rend = GetComponent<Renderer>();
		color = rend.material.GetColor("_TintColor");
		alpha = 1f;
		gameObject.SetActive (true);
		for (int i = 0; i < hoja.Length; i++) {
			hoja [i].SetActive (false);
		}
	}

	void Update () 
	{

		if(audioM.isPlaying){
		}
		else if(!audioM.isPlaying && audioM.clip.isReadyToPlay)
		{
			audioM.Play();
		}
		else
		{
			audioM.clip = Microphone.Start("Micrófono", true,1, 44100);
		}
		float ejeY = audioM.GetSpectrumData(128,0,FFTWindow.BlackmanHarris)[64] * 1000000;
		print(ejeY);
		if(ejeY >=10){
			rend.material.SetColor ("_TintColor", new Color(color.r,color.g,color.b,alpha));
			FadeAlpha ();
			if (!fog.activeInHierarchy) {
				for (int i = 0; i < hoja.Length; i++) {
					
					hoja [i].SetActive (true);
				}
			}
		}
		
	}
	void FadeAlpha(){
		if (alpha > 0f) {
			alpha = alpha - 0.01f;

		} else if (alpha <= 1f) {
			fog.SetActive (false);
			AudioController.instance.StartMusicMenu();
			print (alpha);
		}
	}
}﻿
