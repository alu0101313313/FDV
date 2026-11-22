using UnityEngine;
using UnityEngine.Rendering;

public class EnemyPetMovement : MonoBehaviour
{
	[SerializeField] private Transform owner;
	[SerializeField] private Transform player;
	[SerializeField] private float beltLonguitude = 1.2f;
	[SerializeField] private float speed = 2.5f;
	[SerializeField] private float crunchLonguitude = 1.5f;
	[SerializeField] private float crunchRate = 1f;
	[SerializeField] private int damage = 3;

	private Rigidbody2D rb;
	private float crunchCooldown = 0f;


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
		if (owner != null)
		{
			UnityEngine.Vector2 ownerDirection = (UnityEngine.Vector2)owner.position - rb.position;
			if (ownerDirection.magnitude > beltLonguitude)
			{
				rb.linearVelocity = ownerDirection.normalized * speed;
			}
			else
			{
				rb.linearVelocity = Vector2.zero;
			}
		}

		if (player == null) return;
		crunchCooldown -= Time.fixedDeltaTime;

		float distance = Vector2.Distance(rb.position, player.position);
		if (distance <= crunchLonguitude && crunchCooldown <= 0f)
		{
			Score.Down(damage);
			crunchRate = crunchCooldown;
		}

	}

	void OnDrawGizmosSelected()
	{
		if (owner != null)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawLine(transform.position, owner.position);
		}

		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, crunchLonguitude);
	}

}
