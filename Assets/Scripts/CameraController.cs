using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	private float offset;
	void Start () {
		offset = 6f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(PlayerController.instance.GetPosition().x + offset, transform.position.y,transform.position.z);
	}
}
