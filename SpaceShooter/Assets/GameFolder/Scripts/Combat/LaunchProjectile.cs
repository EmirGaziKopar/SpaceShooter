using SpaceShooter.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] ProjectileController projectilePrefab2;
        [SerializeField] Transform projectileTransform;
        [SerializeField] Transform projectileTransform2;
        [SerializeField] float delay = 0.1f;

        bool delayFinish=false;

        private void Start()
        {
            delayFinish = false;
            
        }
        private void Update()
        {
            delay -= Time.deltaTime;

            if (delay < 0)
            {
                delayFinish = true;
                delay = 0.1f;
            }
            
        }

        public void LaunchAction()
        {
            if(delayFinish == true)
            {
                Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.rotation);
                Instantiate(projectilePrefab2, projectileTransform2.position, projectileTransform2.rotation);
                delayFinish = false;
            }
            
            
        }
    }

}
