using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
	public float speed = 5f;

	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	private Vector2 input;
	
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		input = new Vector2(horizontal, vertical).normalized;

		if(horizontal > 0) spriteRenderer.flipX = true;
		else if (horizontal < 0) spriteRenderer.flipX = false;
	}

	void FixedUpdate()
	{
		rb.linearVelocity = input * speed;
	}
}
