using SpaceShooter.Controllers;
using SpaceShooter.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Spawner
{
    public class EnemiesSpawner : MonoBehaviour
    {
        [Range(2f, 5f)] 
        [SerializeField] float maxSpawnTime = 3f;
        [Range(2f, 5f)]
        [SerializeField] float minSpawnTime = 1f;

        [SerializeField] EnemyController enemy; //Tek tuhaf gelen yer burasý EnemyController Bir script ve biz bunun içersine bir düþman prefabý attýk. Hem prefab tanýmlandý hem'de doðrudan prefabýn içersinde yer alan EnemyController çalýþtý
        
        [SerializeField]float _currentSpawnTime;
        
        [SerializeField] float _timeBoundary;



        private void Awake()
        {
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime); //sýnýr deðerler 
            
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime > _timeBoundary )
            {
                Spawn();
                _currentSpawnTime = 0f;
            }
        }

        void Spawn()
        {
            /*
            GameObject enemyObject = new GameObject("Enemy");

            GameObject enemyObject = new GameObject("Enemy");

            enemyObject.AddComponent<EnemyController>();

            enemyObject.AddComponent<Mover>();

            enemyObject.SetActive(true);

            ayrýca burada oluþturulan enemyObject'in rigitbody'sine ulaþýp kinematic'de yapmak gerekiyor
            */



            //Böyle uðraþmaktansa prefab kullanalým prefab nesnemizin içinde tüm bu componentler olsun tek tek her düþman oluþturduðumuzda Mover EnemyController gibi þeyleri eklemek zorunda kalmayalým.

            Instantiate(enemy, transform.position, transform.rotation); //Bu bizden oluþturacaðý object'i ister yukarýda oluþturduðumuz ve içine prefabýný attýðýmýz enemy nesnesini pozisyon ve rotationunu buraya giriyoruz

            //zaten verdiðimiz prefabýmýzýn içersinde de bunlarýn hepsi var.


        }
    }
}

