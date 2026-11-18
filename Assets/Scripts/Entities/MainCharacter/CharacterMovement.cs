using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 3f;
    public float runSpeed = 6f;
    public float activatedDistance = 5f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Vector3 previousPosition;
    private float distanceTraveled = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        previousPosition = transform.position;
    }

    void Update()
    {
        float horizontalUpdate = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalUpdate, 0);

        bool isRunning = animator.GetCurrentAnimatorStateInfo(0).IsName("Run");
        float currentSpeed = isRunning ? runSpeed : speed;
        transform.Translate(movement * currentSpeed * Time.deltaTime);

        if(horizontalUpdate > 0)
        {
            spriteRenderer.flipX = false;
        } 
        else if (horizontalUpdate < 0)
        {
            spriteRenderer.flipX = true;
        }

        bool moving = horizontalUpdate != 0;
        animator.SetBool("isWalking", moving);

        float distanceThisFrame = Vector3.Distance(previousPosition, transform.position);
        previousPosition = transform.position;

        if (moving)
        {
            distanceTraveled += distanceThisFrame;
        }
        else
        {
            distanceTraveled = 0.0f;
        }
        
        animator.SetBool("longWalk", distanceTraveled > activatedDistance);


    }
}
