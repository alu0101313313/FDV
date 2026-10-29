using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public float stopDistance = 0.1f;

    void Update()
    {
        Vector3 direction = target.position - this.transform.position;

        if (direction.magnitude <= stopDistance) return;

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        this.transform.rotation = Quaternion.Slerp(
            this.transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}