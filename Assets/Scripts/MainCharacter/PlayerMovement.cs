using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 5f;
	private SpriteRenderer spriteRenderer;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		float horizontalUpdate = Input.GetAxis("Horizontal");
		float verticalUpdate = Input.GetAxis("Vertical");

		Vector3 direction = new Vector3(horizontalUpdate, verticalUpdate, 0f).normalized;
		transform.Translate(direction * speed * Time.deltaTime, Space.World);
	
		if (horizontalUpdate < 0) spriteRenderer.flipX = true;
		else if (horizontalUpdate > 0) spriteRenderer.flipX = false;
	}
}
