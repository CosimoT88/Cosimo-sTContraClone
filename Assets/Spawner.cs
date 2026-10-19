using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject prefabtoSpawn;
    public float secondsPassed = 0.0f;
    public float spawnIntervalSeconds = 1.0f;
    public bool isSpawning = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsPassed += Time.deltaTime;
        if (secondsPassed > spawnIntervalSeconds && isSpawning) ;
        {
            Instantiate(prefabtoSpawn, transform.position, transform.rotation);
            secondsPassed = 0;
        }


    }
}
