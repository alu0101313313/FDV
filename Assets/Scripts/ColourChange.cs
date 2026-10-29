using UnityEngine;

public class ColisionColor : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Muestra en consola el nombre del objeto con el que colisiona
        Debug.Log(gameObject.name + " ha colisionado con: " + collision.gameObject.name);

        // Cambia el color a uno aleatorio
        rend.material.color = Random.ColorHSV();
    }
}