using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public float enemyMaxHeath = 100;
    public float enemyCurrentHeath = 100;
    public float movementSpeed;
    private int killReward;
    public float damageToCharactor;
    public GameObject charactor1;




    private void Awake()
    {


    }

    public void takeDamage(float amount)
    {
        enemyCurrentHeath -= amount;

        if (enemyCurrentHeath <= 0)
        {
            die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Arrow"))
        {
            //Arrow arrow = collision.GetComponent<Arrow>();
            //takeDamage(arrow.damage);
            //Debug.Log(arrow.damage);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //CharacterBody characterBody =  collision.gameObject.GetComponent<CharacterBody>();
            //characterBody.takeDamage(damageToCharactor);
            //Debug.Log(damageToCharactor+" Heal"+characterBody.maxHealth);

        }

    }


    private void die()
    {
        Enemies.enemies.Remove(gameObject);
        Destroy(gameObject);
    }

    private void Update()
    {

        if (gameObject.active == true)
        {
            Enemies.enemies.Add(gameObject);
        }



    }

    public void Start()
    {
        
        try
        {
            enemyCurrentHeath = enemyMaxHeath;

        }
        catch
        {

        }



        if (gameObject.active == true)
        {
            Enemies.enemies.Add(gameObject);
        }


    }
}
