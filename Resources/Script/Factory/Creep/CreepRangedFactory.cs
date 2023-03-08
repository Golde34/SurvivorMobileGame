using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class CreepRangedFactory : EnemyFactory
{
    public override void CreateEnemy()
    {
        var portalTransformposition = portalTransform.transform.position;
        var fastCreepGameObject = Resources.Load("Prefabs/CreepRanged") as GameObject;
        if (fastCreepGameObject != null)
        {
            var fastCreep = Instantiate(
                fastCreepGameObject.transform,
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
