using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public Vector3 GoalPosition = new Vector3(22, 10, -14); // posición objetivo
    public float speed = 0.1f;                               // unidades por segundo
    public float arrivalDistance = 0.5f;                    // distancia a la que se considera que ha llegado
    
    private bool arrived = false;                           // flag que indica si ha llegado al objetivo

    void Update()
    {
        // Si ya está lo bastante cerca, se coloca exactamente en el objetivo y se detiene
        if (Vector3.Distance(transform.position, GoalPosition) <= arrivalDistance)
        {
            transform.position = GoalPosition;
            arrived = true;
            return;
        }
        
        this.transform.Translate((GoalPosition - transform.position).normalized * speed * Time.deltaTime);
    }
}
