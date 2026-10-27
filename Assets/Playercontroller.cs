using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Playercontroller : MonoBehaviour
{

    public SpawnerCode bow;

    InputAction attackAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        bow.isSpawning = attackAction.IsPressed();        
    }
}
