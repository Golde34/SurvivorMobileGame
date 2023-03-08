using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepMelee : Creep
{
    private void Awake()
    {
        speed = 1;
        dame = 0;
        heal = 0;
        Diamond = 0;
        range = 1;
    }
}
