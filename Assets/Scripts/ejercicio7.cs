using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
	public Transform GoalPosition;
	public float speed = 1.0f;
	public float accuracy = 0.01f;

	void Update()
	{
		Vector3 direction = GoalPosition.position - this.transform.position;

		if((Vector3.Distance(this.transform.position, GoalPosition.position)) > accuracy)
		{
			this.transform.LookAt(GoalPosition.position);
			this.transform.position = Vector3.MoveTowards(this.transform.position, GoalPosition.position, speed * Time.deltaTime);		
		}
	}
}
