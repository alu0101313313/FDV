using UnityEngine;

public class Damage : MonoBehaviour
{
	private int dmg = 5;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<PhysicMovement>() == null) return;

		Score.Down(dmg);
	}
}
