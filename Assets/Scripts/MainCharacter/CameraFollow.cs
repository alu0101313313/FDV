using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform target;
  private float smoothSpeed = 5f;
  private Vector3 offset = new Vector3(0f, 0f, -10f);

  // Update is called once per frame
  void LateUpdate()
  {
    if (target == null) return;

    Vector3 wishedPosition = target.position + offset;

    float factor = Mathf.Clamp01(smoothSpeed * Time.deltaTime);
    transform.position = Vector3.Lerp(transform.position, wishedPosition, factor);
  }
}
