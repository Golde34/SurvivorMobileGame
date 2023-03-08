using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorBody : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    private float nextTimeToTakeDamage;
    public float timeBetweenEnemyAttack;

    Animator animator;

    void Start()
    {
        currentHealth = maxHealth;

    }

    private void Update()
    {

    }


    public void takeDamage(float amount)
    {

        if (Time.time >= nextTimeToTakeDamage)
        {
            currentHealth -= amount;
            Debug.Log(currentHealth);


            if (currentHealth <= 0)
            {
                die();
            }
            nextTimeToTakeDamage = Time.time + timeBetweenEnemyAttack;
        }

    }

    private void die()
    {
        gameObject.SetActive(false);
    }
}
