using System.Numerics;
using UnityEngine;

public class FollowerEnenyMovement : MonoBehaviour
{
	private Transform player;
	private float enemySpeed = 2.5f;
	private float distanceDetection = 8f;

	private Rigidbody2D rb;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		if (player == null)
		{
			PhysicMovement pj = FindFirstObjectByType<PhysicMovement>();
			if (pj != null) player = pj.transform;
		}
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (player == null) return;

		UnityEngine.Vector2 direction = (UnityEngine.Vector2)player.position - rb.position;

		if (direction.magnitude > distanceDetection)
		{
			rb.linearVelocity = UnityEngine.Vector2.zero;
			return;
		}

		rb.linearVelocity = direction.normalized * enemySpeed;

	}
}
