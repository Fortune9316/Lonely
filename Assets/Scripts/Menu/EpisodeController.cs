using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EpisodeController : MonoBehaviour {

	public Button ep1Btn;
	// Use this for initialization
	void Start () {
		ep1Btn.onClick.AddListener(()=>LoadEpisode1());
	}
	
	// Update is called once per frame
	void Update () {
	}

	void LoadEpisode1()
	{
		ep1Btn.onClick.RemoveAllListeners();
		AudioController.instance.StartEpisode1();
		SceneManager.LoadScene("Episode1");
	}
		
}
