using UnityEngine;
using UnityEngine.AI;

public class MoveAndRotate2D : MonoBehaviour
{
	public float speed = 4f;
	public float rotationSpeed = 180f;

	// Update is called once per frame
	void Update()
	{
		float giro = Input.GetAxis("Horizontal");
		float avance = Input.GetAxis("Vertical");

		transform.Rotate(0f, 0f, -giro * rotationSpeed * Time.deltaTime);

		Vector3 despl = Vector3.up * avance * speed * Time.deltaTime;
		transform.Translate(despl, Space.World);
	}
}
