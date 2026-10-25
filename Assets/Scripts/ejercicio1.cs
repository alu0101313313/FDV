using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public Vector3 GoalPosition = new Vector3(22, 10, -14); // posición objetivo 
    
    public float speed = 5f;                                // unidades por segundo
    public float rotationSpeed = 60f;                       // grados por segundo que puede girar el morro
    public float arrivalDistance = 0.2f;                    // distancia a la que se considera que ha llegado

    private bool arrived = false;                           // flag que indica si ha llegado al objetivo

    void Update()
    {
        // Calculamos la dirección y la distancia al objetivo
        Vector3 direccion = GoalPosition - transform.position;
        float distancia = direccion.magnitude;

        // Si ya está lo bastante cerca, se coloca exactamente en el objetivo y se detiene
        if (distancia <= arrivalDistance)
        {
            transform.position = GoalPosition;
            arrived = true;
            return;
        }

        // Gira poco a poco el morro hacia el objetivo.
        Quaternion rotacionObjetivo = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotacionObjetivo, rotationSpeed * Time.deltaTime);

        // Avanza hacia el objetivo
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}