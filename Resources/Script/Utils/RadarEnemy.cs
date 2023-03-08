using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadarEnemy : MonoBehaviour
{
    public Collider2D[] close = new Collider2D[0];
    GameObject closest;
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponentInParent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        close = Physics2D.OverlapCircleAll(gameObject.transform.position, 5, LayerMask.GetMask("Hero"));

        if (close.Length > 0)
        {
            enemy.onAttack.Invoke();
        }
    }
}
