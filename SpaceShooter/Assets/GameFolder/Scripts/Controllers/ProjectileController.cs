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
            EnemyController enemy = collision.GetComponent<EnemyController>(); //EnemyController'�n componenti oldu�u nesne d��man nesnesi dolay�s�yla burada d��man�n referans de�erini "enemy" i�ine alm�� olduk
            
            if(enemy != null)
            {
                GameManager.Instance.IncreaseScore();
                Destroy(enemy.gameObject); //Burada da merminin collisionu null de�ilse yani bir �eye de�mi� ise d��man� yok et dedik.
                Destroy(this.gameObject); //Burada da ayn� �ekilde mermiyi yok et dedik 
            }
        }

    }
}

