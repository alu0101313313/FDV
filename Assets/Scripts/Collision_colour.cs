using UnityEngine;

public class CollisionColor : MonoBehaviour
{
    private GameObject lastHit;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject objectHit = hit.gameObject;

        if(lastHit == objectHit) return;
        lastHit = objectHit;

        Debug.Log("Collided with: " + objectHit.name);

        Renderer rend = objectHit.GetComponent<Renderer>();

        if(rend != null) rend.material.color = Random.ColorHSV();
        
    }
}