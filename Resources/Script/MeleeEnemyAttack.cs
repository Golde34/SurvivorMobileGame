using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemyAttack : MonoBehaviour
{
    public float attackDamage = 10;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    //Animator animator;
    //Agent agent;

    Transform target = null;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        //agent = GetComponent<Agent>();
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        if (hitEnemies != null)
        {

            
            
            foreach (Collider2D enemy in hitEnemies)
            {
                if (enemy.tag.Equals("Player"))
                {

                    enemy.GetComponent<CharacterBody>().takeDamage(attackDamage);
                    Debug.Log("hit charactor");
                }



            }
        }
        else
        {
            Debug.Log("null");
        }


    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


    private void SetAngleAttack(Transform target)
    {
        if (target != null)
        {
            Vector2 relative = target.position - gameObject.transform.position;
            float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg - 90f;
            //animator.SetFloat("Angle", angle);
        }
    }

    // Update is called once per frame
    void Update()
    {


        try
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;




        }
        catch
        {

        }


        float distanceBetweenObjects = Vector2.Distance(attackPoint.position, target.position);

        //Debug.Log(distanceBetweenObjects);

        if (target != null)
        {
            if (distanceBetweenObjects <= attackRange)
            {

                //agent.state = Agent.EnemyState.NOTHING;
                //SetAngleAttack(target);
                //animator.SetTrigger("Attack");
                
                Attack();
            }
            else
            {
                //agent.state = Agent.EnemyState.CHASE;
                //animator.SetBool("Attack", false);
            }
        }



    }
}
