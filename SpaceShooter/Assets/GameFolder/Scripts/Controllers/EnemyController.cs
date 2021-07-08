using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float time = 3f;



        private void Update()
        {
            time -= Time.deltaTime;
            if(time < 0)
            {
                Destroy(this.gameObject);
            }
        }



    }

}
