using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int health = 100;
    public GameObject deathEffect;
    public GameObject coin;

    public void TakeDamage (int damage)
    {
        health -= damage;
        if ( health <= 0 ){
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(coin, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
