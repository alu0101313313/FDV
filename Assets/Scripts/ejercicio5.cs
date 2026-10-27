using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    public float speed = 5f;
    CharacterController controller;

    void Awake() => controller = GetComponent<CharacterController>();

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        float space = Input.GetKey(KeyCode.Space) ? 1f : 0f;

        if(space > 0f)
        {
            speed++;
        }

        Vector3 move = new Vector3(x, 0, z).normalized;

        controller.Move(move * speed * Time.deltaTime);
    }
}
