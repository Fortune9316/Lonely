using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{

	Button starts,option,credits,menu;
	private Slider sliderAmb,sliderEfe;
	public static Botones instance;

	void Awake(){
		instance = this;
	}
	void Start ()
	{
		starts = GetComponent<Button> ();
		menu = GetComponent<Button> ();
		option = GetComponent<Button> ();
		credits = GetComponent<Button> ();
		cambios ();
		try{
			sliderAmb = GameObject.Find ("Ambiental").GetComponent<Slider> ();
			sliderEfe = GameObject.Find ("Efectos").GetComponent<Slider> ();
		}catch{
			
		}
	}
	void cambios ()
	{
		switch (gameObject.name) {
		case "start":
			starts.onClick.AddListener (() => goGame ());
			break;
		case "options":
			option.onClick.AddListener (() => goOptions ());
			break;
		case "credits":
			credits.onClick.AddListener (() => goCredits ());
			break;
		case"menu":
			menu.onClick.AddListener (() => goMenu ());
			break;
		}
	}

	void goGame ()
	{
		SceneManager.LoadScene ("Episodes");
	}

	void goOptions ()
	{
		SceneManager.LoadScene ("Options");
	}

	void goCredits ()
	{
		SceneManager.LoadScene ("Credits");
	}

	void goMenu ()
	{
		PlayerPrefs.SetFloat ("volumenAmb", sliderAmb.value);
		PlayerPrefs.SetFloat ("volumenEfe", sliderEfe.value);
		SceneManager.LoadScene ("Menu");

	}

}
