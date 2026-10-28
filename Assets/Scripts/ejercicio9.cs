using UnityEngine;


public class ejercicio9 : MonoBehaviour
{
	public Transform[] Waypoints;
	public float speed = 1.0f;
	public float accuracy = 0.01f;
	public float rotationSpeed = 1.0f;
	private int waypointIndex = 0;

	void Update()
	{		
		Vector3 direction = Waypoints[waypointIndex].position - this.transform.position;

		if(direction.magnitude < accuracy)
		{
			waypointIndex++;
			if (waypointIndex >= Waypoints.Length)
			{
				waypointIndex = 0;
			}
		}
		Quaternion lookRotation = Quaternion.LookRotation(direction);
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
		this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
  }
}
