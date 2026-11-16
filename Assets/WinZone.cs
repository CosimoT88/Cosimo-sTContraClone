using UnityEngine;

public class WinZone : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent onWinReached;
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.GetComponent<Playercontroller>())
        onWinReached.Invoke();
        Debug.Log("You win nothing congrats");
}   }