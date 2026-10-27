using UnityEngine;

public class EnemyspawnTrig : MonoBehaviour
{
    public SpawnerCode spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner= GetComponent<SpawnerCode>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.GetComponent<Playercontroller>() != null)      
        {
            spawner.isSpawning = true;
            Debug.Log(gameObject.name + "Player Found");
        }
        

    }

    private void OnTriggerExit(Collider2D collision)
    {
        Playercontroller playerReference  = collision.GetComponent<Playercontroller>();
        if (playerReference  != null)
        {
            spawner.isSpawning = false;
            Debug.Log(gameObject.name + "PLAYER GONE");
        }
        
    }
}
