using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoviment : MonoBehaviour
{


    public ParticleSystem DustParticle;

    public Animator animator;

    private float moveInput;
    public float speed = 8f;
    public float deceleration = 8f;
    public float acceleration = 8f;
    public float velPower = 8f;

    public float jumpingPower = 15f;
    public float jumpingMultiplier = 2f;
    private bool isFacingRight = true;

    private bool isJumping;
    private bool jumpKeyUp;


    private float coyoteTime = 0.2f;
    private float coyoteTimeCounter;

    private float normalGravity = 1.2f;
    float gravityMultiplier;
    public float gravityMultiplierValue;
    public float maxGravityValue;

    private float jumpBufferTime = 0.2f;
    private float jumpBufferCounter;
    private bool jumpBufferTokens;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Start()
    {
        gravityMultiplier = gravityMultiplierValue;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        jumpKeyUp = Input.GetButtonUp("Jump");

        if (isJumping && rb.velocity.y > 0)
        {
            animator.SetBool("IsJumping", true);
        }

        if(rb.velocity.y < 0)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("Falling", true);
        }
        else
        {
            animator.SetBool("Falling", false);
        }

        if (IsGrounded())
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("Falling", false);
            coyoteTimeCounter = coyoteTime;
            jumpBufferTokens = true;
            rb.gravityScale = 1f;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

        if (rb.velocity.y < 1 && !IsGrounded())
        {
            gravityMultiplier =+ gravityMultiplier + Time.deltaTime * 9;
            rb.gravityScale = normalGravity + gravityMultiplier;
            if (rb.gravityScale >= maxGravityValue)
            {
                gravityMultiplier = maxGravityValue;
                rb.gravityScale = maxGravityValue;
            }
        }

        else if (IsGrounded())
        {
            gravityMultiplier = gravityMultiplierValue;
            rb.gravityScale = normalGravity;
        }

        if (Input.GetButtonDown("Jump") && jumpBufferTokens)
        {
            jumpBufferCounter = jumpBufferTime;
            jumpBufferTokens = false; 
            
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
            
        }

        if (coyoteTimeCounter > 0f && jumpBufferCounter > 0f && !isJumping)
        {
            Jump();
        }

        if (jumpKeyUp && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);

        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.AddForce(Vector2.up * (jumpingPower * jumpingMultiplier), ForceMode2D.Impulse);

            coyoteTimeCounter = 0f;
        }
        


        Flip();
    }

    private void FixedUpdate()
    {
        Run();
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * (jumpingPower * jumpingMultiplier), ForceMode2D.Impulse);

        jumpBufferCounter = 0f;

        ReleaseDust();

        StartCoroutine(JumpCooldown());
        FindObjectOfType<AudioManager>().Play("Pular");
    }

    void ReleaseDust()
    {
        DustParticle.Play();
    }

    private void Run()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        float targetSpeed = moveInput * speed;

        float desiredVelocity = targetSpeed - rb.velocity.x;

        float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? acceleration : deceleration;

        float movement = Mathf.Pow(Mathf.Abs(desiredVelocity) * accelRate, velPower) * Mathf.Sign(desiredVelocity);

        rb.AddForce(movement * Vector2.right);
    }
    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        
    }

    private void Flip()
    {
        if (isFacingRight && moveInput < 0f || !isFacingRight && moveInput > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
            if (IsGrounded())
            {
                ReleaseDust();
            }
        }
    }

    private IEnumerator JumpCooldown()
    {
        isJumping = true;
        yield return new WaitForSeconds(0.4f);
        isJumping = false;
    }
} 