using UnityEngine;

public class ejercicio8 : MonoBehaviour
{
	public Transform GoalPosition;
	public float speed = 1.0f;
	public float accuracy = 0.01f;
	public float rotationSpeed = 1.0f;

	void Update()
	{
		Vector3 direction = GoalPosition.position - this.transform.position;

		if(direction.magnitude > accuracy)
		{
			Quaternion targetRotation = Quaternion.LookRotation(direction);
			
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}