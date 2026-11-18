using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 3f;
    
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalUpdate = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalUpdate, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        if(horizontalUpdate > 0)
        {
            spriteRenderer.flipX = false;
        } 
        else if (horizontalUpdate < 0)
        {
            spriteRenderer.flipX = true;
        }

        animator.SetBool("isWalking", horizontalUpdate != 0);
    }
}
