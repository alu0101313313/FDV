using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ZoomBehaviour : MonoBehaviour
{
	[SerializeField] private CinemachineCamera cineCamera;
	[SerializeField] private float zoomSpeed = 5f;
	[SerializeField] private float minSize = 3f;
	[SerializeField] private float maxSize = 10f;

	void Update()
	{
		float input = 0f;

		if(Input.GetKey(KeyCode.W)) input -= 1f;
		if(Input.GetKey(KeyCode.S)) input += 1f;

		if(input == 0f) return;

		var lens = cineCamera.Lens;
		lens.OrthographicSize = Mathf.Clamp(lens.OrthographicSize + input * zoomSpeed * Time.deltaTime, minSize, maxSize);
		cineCamera.Lens = lens;
	}
}
