using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerCode : MonoBehaviour//giving the code a class
//class being defined by the contents in the curly brackets 
{
    //variables made public to be changed to make the game better.
    public GameObject prefabtoSpawn; //reference to the object spawing
    public float secondspass = 0.0f; // value type
    public float spawnIntervalSecs = 1.0f;
    public bool isSpawning = true;

    // Update is called once per frame
    void Update()
    {
        secondspass += Time.deltaTime;

        if(secondspass>spawnIntervalSecs && isSpawning)
        {
            Instantiate(prefabtoSpawn, transform.position, transform.rotation);
            secondspass = 0;
        }
    }
}
