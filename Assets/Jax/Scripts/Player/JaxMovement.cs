using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaxMovement : MonoBehaviour
{
    public Animator player;
    private float horizontal;
    public float speed = 6f;
    public float jumpingPower = 9.75f;
    private bool isFacingRight = true;
    private bool canDash = true;
    private bool isDashing;
    public float dashingPower = 8f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;

    private void Update()
    {
        if (isDashing)
        {
            return;
        }


        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal == 0)
        {
            GetComponent<Animator>().SetInteger("PlayerInput", 0);
        }
        else
        {
            GetComponent<Animator>().SetInteger("PlayerInput", 1);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            GetComponent<Animator>().SetInteger("PlayerInput", 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }


        Flip();

    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        GetComponent<Animator>().SetTrigger("Jump");
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(groundCheck.position, 0.2f);
    }

    private void Flip()
    {

        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {

            Vector3 theScale = transform.localScale;
            isFacingRight = !isFacingRight;
            theScale.x *= -1f;
            transform.localScale = theScale;

        }

    }

    private IEnumerator Dash()
    {
        GetComponent<Animator>().SetInteger("PlayerInput", 3);
        canDash = false;
        tr.emitting = true;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);

        yield return new WaitForSeconds(dashingTime);

        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;

    }


}