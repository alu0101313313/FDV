using UnityEngine;

public class Cilinder_movement : MonoBehaviour
{
    public float force = 10f;     // Intensidad de la fuerza
    public float maxSpeed = 5f;   // Límite de velocidad

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Entrada del teclado: WASD o flechas
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Dirección de movimiento en el plano XZ
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        // Aplicar fuerza
        rb.AddForce(direction * force);

        // Limitar la velocidad horizontal para que no crezca sin control
        Vector3 speed = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (speed.magnitude > maxSpeed)
        {
            Vector3 limited = speed.normalized * maxSpeed;
            rb.linearVelocity = new Vector3(limited.x, rb.linearVelocity.y, limited.z);
        }
    }
}
