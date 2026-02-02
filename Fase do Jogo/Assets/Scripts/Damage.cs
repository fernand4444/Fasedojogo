using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public int damage = 15;

    void OnCollisionEnter2D(Collision2D collision)
    {
        while (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
