using UnityEngine;
using UnityEngine.UIElements;

public class AiController : MonoBehaviour
{
    public CharacterMovement movement;

    float timer = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
        movement.moveInputDir = Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        movement.moveInputDir = new Vector2(1, 0);
        timer-= Time.deltaTime;

        if (timer < 0)
        {
            movement.moveInputDir.y = 0;
            timer = 2;

            movement.moveInputDir *= -1;
            timer = 2;
        }
    }
}
