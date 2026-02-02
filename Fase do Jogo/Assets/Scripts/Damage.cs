using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            else
            {
                Die();
            }
        }
    }
    void Die()
    {
        Debug.Log("Player morreu!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
