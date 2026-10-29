using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SphereBehaviour : MonoBehaviour
{
    public Transform objetivo;          // Cilindro
    public float speed = 3f;
    public float stopDistance = 0.2f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (objetivo == null) return;

        // Dirección horizontal hacia el objetivo
        Vector3 direction = objetivo.position - rb.position;
        direction.y = 0f;

        if (direction.magnitude <= stopDistance)
        {
            rb.linearVelocity = new Vector3(0f, rb.linearVelocity.y, 0f);
            return;
        }

        Vector3 sphereSpeed = direction.normalized * speed;
        rb.linearVelocity = new Vector3(sphereSpeed.x, rb.linearVelocity.y, sphereSpeed.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        CubeBehaviour cubo = collision.gameObject.GetComponent<CubeBehaviour>();
        if (cubo != null)
        {
            cubo.Activar();
        }
    }
}
