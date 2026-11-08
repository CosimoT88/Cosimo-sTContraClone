using UnityEngine;

public class EnemyspawnTrig : MonoBehaviour
{
    public SpawnerCode spawner;

    void Start()
    {
        // Find the SpawnerCode component
        spawner = GetComponent<SpawnerCode>();

        // Make sure spawning starts OFF
        spawner.isSpawning = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Playercontroller>() != null)
        {
            spawner.isSpawning = true;
            Debug.Log("PLAYER ENTERED: Spawning ON");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Playercontroller>() != null)
        {
            spawner.isSpawning = false;
            Debug.Log("PLAYER EXITED: Spawning OFF");
        }
    }
}