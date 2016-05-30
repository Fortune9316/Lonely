using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeepAudio : MonoBehaviour
{

	// Use this for initialization
	[HideInInspector]
	public float volumenAmb, volumenEfe;
	Slider sliderAmb, sliderEfe;
	public static KeepAudio instance;

	void Awake ()
	{
		instance = this;
		DontDestroyOnLoad (this);
	}

	void Start ()
	{
		
		sliderAmb = GameObject.Find ("Ambiental").GetComponent<Slider> ();
		sliderEfe = GameObject.Find ("Efectos").GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		volumenAmb = sliderAmb.value;
		volumenEfe = sliderEfe.value;
	}
}
