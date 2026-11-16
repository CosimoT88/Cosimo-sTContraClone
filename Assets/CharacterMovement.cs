using UnityEngine;


public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 8f;
    public float jumpForce = 4f;

    public bool isGrounded = false;
    public Vector2 moveInputDir;

    public Transform GroundChecker;

    int terrainLayerMask;

    public bool isJumpRequested = false;

    void Start()
    {
        terrainLayerMask = LayerMask.GetMask("Terrain");
    }

    void Update()
    {
        rb.linearVelocityX = moveInputDir.x * moveSpeed;

        if (isJumpRequested)
        {
            Jump();
        }

        // Checks if the character is touching the ground
        Collider2D groundCollision = Physics2D.OverlapCircle(
            GroundChecker.position,
            0.2f,
            terrainLayerMask
        );

        isGrounded = groundCollision != null;
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
        if (collision.gameObject.layer == LayerMask.NameToLayer("Terrain"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Terrain"))
        {
            isGrounded = false;
        }
    }
}