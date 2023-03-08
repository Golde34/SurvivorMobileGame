using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMini : Boss
{
    // Start is called before the first frame update
    private void Awake()
    {
        speed = 1;
        dame = 0;
        heal = 0;
        Diamond = 0;
        range = 1;
    }
}
