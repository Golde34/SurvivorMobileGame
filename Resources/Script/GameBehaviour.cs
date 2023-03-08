using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    // Gets the transform attribute of portals into a list
    List<Transform> portals;
    int i = 0;

    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        portals = new List<Transform>();

        // Initiates timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = Random.Range(2, 5);
        timer.Run();

        // Gets the prefab from Resourses folder and spawns it
        var bossPortalGameObject = Resources.Load("Prefabs/BossPortal") as GameObject;
        if (bossPortalGameObject != null)
        {
            var bossPortal = Instantiate(
                bossPortalGameObject.transform,
                new Vector3(0, 10, 1),
                Quaternion.identity
            );
            // Assigns the factory type to portal
            bossPortal.gameObject.AddComponent<BossBigFactory>();
            // Adds the portal into list
            portals.Add(bossPortal);
        }
        else
        {
            // Throw an error if the prefab doesn't exist
            throw new System.ArgumentException("Prefab does not exist.");
        }

        // Gets the prefab from Resourses folder and spawns it
        var creepPortalGameObject = Resources.Load("Prefabs/BossPortal") as GameObject;
        if (creepPortalGameObject != null)
        {
            var creepPortal = Instantiate(
                creepPortalGameObject.transform,
                new Vector3(0, 10, 1),
                Quaternion.identity
            );
            // Assigns the factory type to portal
            creepPortal.gameObject.AddComponent<BossMiniFactory>();
            // Adds the portal into list
            portals.Add(creepPortal);
        }
        else
        {
            // Throw an error if the prefab doesn't exist
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Spawns an enemy based on the factory type it belongs to (boss/creep) according to the portal when Timer finishes
        if (timer.Finished)
        {
            // This entire section is basically a [for()] loop
            // If ur a noob, remember not to put any sort of loop into [Update()] method, ever!
            // Turn the loop into some sort of iterative method like below, because [Update()] (or [FixedUpdate()]) itself is already a loop which reiterates every frame
            // In the case of [Update()], the higher fps your PC can go, the worse things will get if you put another loop in it
            if (i < portals.Count)
            {
                portals[i].gameObject.GetComponent<EnemyFactory>().portalTransform = portals[i];

                // Spawns an enemy of random variant (fast/slow) on the portal's position

                portals[i].gameObject.GetComponent<EnemyFactory>().CreateEnemy();

                i++;
            }
            else
            {
                i = 0;
            }

            // Restarts the Timer
            timer.Duration = Random.Range(2, 5);
            timer.Run();
        }
    }
}
