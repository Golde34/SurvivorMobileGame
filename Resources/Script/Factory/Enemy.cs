using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public abstract class Enemy : MonoBehaviour
{
    protected float speed;
    protected float dame;
    protected float heal;
    protected int Diamond;
    protected float range;
    protected RadarEnemy radar;
    public UnityEvent onAttack;
    private NavMeshAgent agent;

    Timer timer;

    public enum EnemyType
    {
        Boss, Creep
    }

    public abstract EnemyType GetEnemyType();
    // Start is called before the first frame update

    void Start()
    {
        #region Initiates timer

        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();

        #endregion

        #region Attach radar

        radar = gameObject.AddComponent<RadarEnemy>();

        if (onAttack == null)
            onAttack = new UnityEvent();
        onAttack.AddListener(Attack);

        #endregion

        #region NavMesh setup
        
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(new Vector3(0, 0, 0));
    }

    void Attack()
    {
        // Perform the attack action
        // ...
    }
}
