using UnityEngine;
using UnityEngine.InputSystem;

public class InputMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    InputAction moveAction;
    InputAction jumpAction;
    public float moveSpeed = 8f;
    public float jumpForce = 5f;
    public bool playerJumping;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInputDir = moveAction.ReadValue<Vector2>();

        rb.linearVelocityX = moveInputDir.x * moveSpeed;

        if (jumpAction.WasPressedThisFrame() && !playerJumping)
        {
            rb.linearVelocityY = jumpForce;
            playerJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        playerJumping = false;
    }

}