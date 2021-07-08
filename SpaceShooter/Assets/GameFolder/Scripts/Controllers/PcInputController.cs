using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Controllers
{
    public class PcInput 
    {
        public bool leftClick => Input.GetMouseButtonDown(0);

        public bool rightClick => Input.GetMouseButtonDown(1);
        //0 -> left click of mouse 1-> rigth click of mouse 2-> Mid
        /* up = x=0 y=1 but that's not enought therefore we create a coefficient and multiply with it, and this determines the value of our force.  */

    }

}

