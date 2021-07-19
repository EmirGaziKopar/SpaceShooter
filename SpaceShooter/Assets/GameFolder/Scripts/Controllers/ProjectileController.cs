using SpaceShooter.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Controllers
{
    public class ProjectileController : LifeCycleController
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyController enemy = collision.GetComponent<EnemyController>(); //EnemyController'ýn componenti olduðu nesne düþman nesnesi dolayýsýyla burada düþmanýn referans deðerini "enemy" içine almýþ olduk
            
            if(enemy != null)
            {
                GameManager.Instance.IncreaseScore();
                Destroy(enemy.gameObject); //Burada da merminin collisionu null deðilse yani bir þeye deðmiþ ise düþmaný yok et dedik.
                Destroy(this.gameObject); //Burada da ayný þekilde mermiyi yok et dedik 
            }
        }

    }
}

