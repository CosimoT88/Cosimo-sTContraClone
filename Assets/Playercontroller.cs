using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Playercontroller : MonoBehaviour
{

    public SpawnerCode bow;

    InputAction attackAction;
    InputAction AimAction;  //the input to allow player to aim


    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
        AimAction = InputSystem.actions.FindAction("Move");
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 AimInputDir = AimAction.ReadValue<Vector2>();
        bow.isSpawning = attackAction.IsPressed();
        bow.transform.right = AimInputDir;

        Debug.DrawRay(bow.transform.position, AimInputDir * 2, Color.red); //draws the direction of the gun aiming
    }
}