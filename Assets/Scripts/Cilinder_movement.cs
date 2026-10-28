using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Cilinder_movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    CharacterController controller;

    void Awake() => controller = GetComponent<CharacterController>();

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0, z).normalized;

        controller.Move(move * speed * Time.deltaTime);
    }
}
