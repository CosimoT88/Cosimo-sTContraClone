using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerCode : MonoBehaviour

{
    public GameObject prefabtoSpawn;
    public float secondspass = 0.0f;
    public float spawnIntervalSecs = 1.0f;

    InputAction attackAction;
    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");       
    }

    // Update is called once per frame
    void Update()
    {
        secondspass += Time.deltaTime;

        if(secondspass>spawnIntervalSecs && attackAction.IsPressed())
        {
            Instantiate(prefabtoSpawn, transform.position, transform.rotation);
            secondspass = 0;
        }
    }
}
