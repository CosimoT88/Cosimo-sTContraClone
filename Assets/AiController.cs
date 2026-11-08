using UnityEngine;

public class AiController : MonoBehaviour
{
    public CharacterMovement movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.moveInputDir = new Vector2(1, 0);
    }
}
