using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;

    public float Perofvuln = 0;
    float vulnTimer = 0;
    int rightLayer;

    void Start()
    {
        rightLayer = gameObject.layer;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        health--;
        vulnTimer = Perofvuln;
        gameObject.layer = 8;
        
    }

    void Update()
    {
        vulnTimer -= Time.deltaTime;
        if(vulnTimer <= 0)
        {
            gameObject.layer = rightLayer;
        }
        
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
