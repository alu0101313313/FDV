using UnityEngine;

public class ThrowPlace : MonoBehaviour
{
    private float force = 12f;
    private float duration = 0.4f;

    void OnTriggerEnter2D(Collider2D other)
    {
        PhysicMovement player = other.GetComponent<PhysicMovement>();
        if (player == null) return;

        Vector2 direction = transform.up;
        player.Throw(direction * force, duration);
    }
}
