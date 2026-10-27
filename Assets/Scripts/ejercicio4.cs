using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public Transform GoalPosition;          // posición objetivo
    public float speed = 1.0f;              // unidades por segundo
    public float arrivalDistance = 0.5f;    // distancia a la que se considera que ha llegado
    private bool arrived = false;           // flag que indica si ha llegado al objetivo
    
    void Start()
    {
        // Orienta el objeto hacia la posición objetivo al inicio
        this.transform.LookAt(GoalPosition.position);
    }

    void Update()
    {
        // Si ya ha llegado, no hace nada
        if (arrived) return; 
        
        // Calcula la dirección hacia el objetivo
        Vector3 direction = GoalPosition.position - transform.position;

        // Si ya está lo bastante cerca, se coloca exactamente en el objetivo y se detiene
        if (Vector3.Distance(transform.position, GoalPosition.position) <= arrivalDistance)
        {
            transform.position = GoalPosition.position;
            arrived = true;
            return;
        }

        // Dibuja un rayo rojo desde la posición del objeto hacia la dirección del objetivo
        Debug.DrawRay(this.transform.position, direction, Color.red);
        
        // Mueve el objeto hacia la posición objetivo
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
