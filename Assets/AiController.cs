using UnityEngine;
using UnityEngine.UIElements;

public class AiController : MonoBehaviour
{
    public CharacterMovement movement;

    float timer = 2;
    int terrainLayerMask;
    public float lookaheadDistant = 0.5f;
    public Transform GroundChecker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
        movement.moveInputDir = Vector2.left;
        terrainLayerMask = LayerMask.GetMask("Terrain");
    }

    // Update is called once per frame
    void Update()
    {
        //Checks for a wall
        RaycastHit2D rayCollision = Physics2D.CapsuleCast(
            transform.position,
            new Vector2(0.6f, 0.3f),
            CapsuleDirection2D.Vertical,
            0,
           movement.moveInputDir,
           lookaheadDistant,
           terrainLayerMask
           );
       


        bool obstacleAhead = rayCollision.collider != null;

        if (obstacleAhead)
        {
            movement.moveInputDir *= -1;

        }
        //if no ground ahead, then jump
        Collider2D groundCollision = Physics2D.OverlapCircle(
            (Vector2)GroundChecker.position + movement.moveInputDir * lookaheadDistant,
            0.1f, 
            terrainLayerMask
            );
        bool groundAhead = groundCollision != null;

        if (!groundAhead)
        {
            movement.Jump();
        }
    }
}
