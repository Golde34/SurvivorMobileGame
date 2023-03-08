using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BossBigFactory : EnemyFactory
{
    public override void CreateEnemy()
    {
        var portalTransformposition = portalTransform.transform.position;
        var fastBossGameObject = Resources.Load("Prefabs/BossBig") as GameObject;
        if (fastBossGameObject != null)
        {
            var fastBoss = Instantiate(
                fastBossGameObject.transform,
                new Vector3(
                    portalTransformposition.x,
                    portalTransformposition.y,
                    portalTransformposition.z
                ),
                Quaternion.identity
            );
        }
        else
        {
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }
}
