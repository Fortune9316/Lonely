using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

	// Use this for initialization

	public AudioClip [] clipsBackground;
	public static AudioController instance;

	private AudioSource [] audioSources; //0 musica de fondo, 1 efectos

	void Awake(){
		if(instance != null){
			Destroy (gameObject);
		}else{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	void Start () {
		audioSources = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartMusicMenu()
	{
		audioSources[0].clip = clipsBackground[0];
		audioSources[0].loop = true;
		audioSources[0].Play();
	}
	public void StartEpisode1()
	{
		audioSources[0].Stop();
		audioSources[0].clip = clipsBackground[1];
		audioSources[0].loop = true;
		audioSources[0].Play();
	}
	public void StopAll()
	{
		audioSources[0].Stop();
	}

	public AudioSource GetMainAudioSource()
	{
		return audioSources[0];
	}
}
