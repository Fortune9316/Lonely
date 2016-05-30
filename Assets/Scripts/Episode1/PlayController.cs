using UnityEngine;
using System.Collections;

public class PlayController : MonoBehaviour {

	// Use this for initialization
	AudioSource audioSource;

	private float counter;
	private bool isMoving;
	void Start () {
		isMoving = false;
		counter = 0f;
		audioSource = AudioController.instance.GetMainAudioSource();
	}
	
	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		if(PlayerController.instance.velocity.x > 0f)
		{
			if(counter >= 0.3f && audioSource.pitch<1)
			{
				audioSource.pitch += 0.1f;
				counter = 0f;
			}
		} else if(PlayerController.instance.velocity.x == 0f)
		{
			if(counter >= 0.3f && audioSource.pitch>0)
			{
				audioSource.pitch -= 0.1f;
				counter = 0f;
			}
		}
		if(audioSource.pitch <= 0f)
		{
			print("asdfasdfas");
			audioSource.pitch = 0f;
		}
	}

}
