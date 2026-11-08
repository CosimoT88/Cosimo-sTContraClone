using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Playercontroller : MonoBehaviour
{

    public SpawnerCode bow;
    public CharacterMovement movement;

    InputAction attackAction;
    InputAction AimAction;  //the input to allow player to aim
    InputAction jumpAction;


    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        AimAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");

        movement = GetComponent<CharacterMovement>();

    }


    // Update is called once per frame
    void Update()
    {
        Vector2 AimInputDir = AimAction.ReadValue<Vector2>();
        bow.isSpawning = attackAction.IsPressed();
        bow.transform.right = AimInputDir;

        Debug.DrawRay(bow.transform.position, AimInputDir * 2, Color.red); //draws the direction of the gun aiming


        movement.moveInputDir = AimInputDir;
        if (jumpAction.WasPressedThisFrame())
        {
            movement.Jump();
        }
    }
}