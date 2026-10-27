using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    public Transform goal;          // posición objetivo
    public float speed = 1.0f;      // unidades por segundo
    
    void Update()
    {
        this.transform.LookAt(goal.position);
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
