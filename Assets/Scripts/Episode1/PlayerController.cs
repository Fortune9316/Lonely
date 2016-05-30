using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public static PlayerController instance;
	public Vector2 velocity;

	private Rigidbody2D rb;
	private Animator animator;
	float speed;

	void Awake()
	{
		instance = this;	
	}
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		speed = 0f;
		if(Input.GetKey(KeyCode.RightArrow))
		{
			animator.Play("Walk");
			speed = 25f;
		}
		if(speed == 0f)
		{
			animator.Play("Stand");
		}
		/*if(Input.GetKey(KeyCode.LeftArrow))
		{
			speed = -50f;
		}*/
		velocity = rb.velocity;

	}
	void FixedUpdate()
	{
		rb.velocity = new Vector2(speed * 0.1f,rb.velocity.y);
	}

	public Vector3 GetPosition()
	{
		return transform.position;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "minimizar")
		{
			transform.localScale -= new Vector3(0.5f,0.5f,0.5f);
			col.gameObject.SetActive(false);
		}
	}
}
