using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
	public float speed = 2f;
	public float amplitude = 3f;
	private Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		float desplazamiento = Mathf.Sin(Time.time * speed) * amplitude;
		transform.position = startPosition + new Vector3(desplazamiento, 0f, 0f);
	}
}
