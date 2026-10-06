using UnityEngine;

public class BackgroundParrallax : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    
    
    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position*0.1f; // Move the background at a slower speed than the player
    }
}
