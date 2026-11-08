using UnityEngine;
public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 8f;
    public float jumpForce = 4f;
    public bool isGrounded=false;
    public Vector2 moveInputDir;

    public bool isJumpRequested=false; 
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = moveInputDir.x * moveSpeed;
        if (isJumpRequested)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rb.linearVelocityY = jumpForce;
            isJumpRequested = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = true;
    }

}