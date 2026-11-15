using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
  //Properties
   public int damage = 1;
   public bool destroySelfOnDamage = true;


  //Functions
void DealDamageTo(GameObject objectToDamage)
{
    //Get Damagable
    Damagable hp = objectToDamage.GetComponent<Damagable>();
     if (hp != null)
     {
         hp.TakeDamage(damage);

         if(destroySelfOnDamage)
      {
         Destroy(gameObject);  
      }
    }
  }


  private void OnCollisionEnter2D(Collision2D collision)
  {
     DealDamageTo(collision.gameObject);
  }

  private void OnTriggerEnter2D(Collider2D collider)
  {
    DealDamageTo(collider.gameObject);
  }
}
