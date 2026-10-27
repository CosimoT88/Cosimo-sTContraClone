using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    public float speed = 20.0f;
    //public Vector2 velocity = new Vector2(100, 0);  
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent < Rigidbody2D >().linearVelocity = transform.right * speed;
    }
}
