using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SocialPlatforms;

public class BossBig : Boss
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
