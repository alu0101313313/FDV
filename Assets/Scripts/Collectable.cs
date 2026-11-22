using UnityEngine;

public class Collectable : MonoBehaviour
{
	private int value = 10;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<PhysicMovement>() == null) return;

		Score.Up(value);
		Destroy(gameObject);
	}
}
