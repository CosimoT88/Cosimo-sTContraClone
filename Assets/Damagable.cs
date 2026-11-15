using UnityEngine;

public class Damagable : MonoBehaviour
{
  public int HP = 1;
  public UnityEngine.Events.UnityEvent onDeath;
 // public bool destroyOnDeath = true;//

  public void TakeDamage(int damage)
  {
      HP -= damage;

      if(HP <= 0)
      {
          Die();
      }
  }

  public void Die()
  {
    if(onDeath != null)
    {
      onDeath.Invoke();  
    }
      Destroy(gameObject);
  }
}
