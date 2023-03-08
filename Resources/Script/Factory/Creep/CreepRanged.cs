using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepRanged : Creep
{
    private void Awake()
    {
        speed = 2;
        dame = 0;
        heal = 0;
        Diamond = 0;
        range = 2;
    }
}
