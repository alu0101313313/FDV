using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeBehaviour : MonoBehaviour
{
    public Material activateMaterial; // Material que se aplicará al cubo cuando sea activado
    public float acceleration = 1f;

    private Rigidbody rb;
    private Renderer rend;
    private bool active = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rend = GetComponent<Renderer>();
    }

    // Llamado por la esfera al chocar
    public void Activar()
    {
        if (active) return;

        active = true;
        if (activateMaterial != null)
        {
            rend.material = activateMaterial;
        }
    }

    void FixedUpdate()
    {
        if (!active) return;

        // Avanza en la dirección hacia la que mira el cubo (su eje forward)
        Vector3 despl = transform.forward * acceleration * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + despl);
    }
}
