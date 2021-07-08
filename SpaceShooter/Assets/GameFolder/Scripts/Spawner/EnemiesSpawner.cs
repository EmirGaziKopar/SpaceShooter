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
        [SerializeField] float maxSpawnTime = 10f;
        [Range(2f, 5f)]
        [SerializeField] float minSpawnTime = 2f;

       /* EnemyController enemy; *///Tek tuhaf gelen yer burasý EnemyController Bir script ve biz bunun içersine bir düþman prefabý attýk. Hem prefab tanýmlandý hem'de doðrudan prefabýn içersinde yer alan EnemyController çalýþtý
        
        [SerializeField]float _currentSpawnTime;
        
        [SerializeField] float _timeBoundary;

        public EnemyController[] enemies;



        private void Start()
        {
            ResetTime();
            getTime();//Oyun her baþladýðýnda düþmanlarýn çýkýþ zamanýnýn farklý olmasýný saðlýyor 
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime > _timeBoundary )
            {
                getTime(); //Her adýmda düþmanlarýn çýkýþ zamnýnýn farklý olmasýný saðlýyor
                ResetTime();
                Spawn();
                
               
            }
        }

        void Spawn()
        {
            /*
           

            GameObject enemyObject = new GameObject("Enemy");

            enemyObject.AddComponent<EnemyController>();

            enemyObject.AddComponent<Mover>();

            enemyObject.SetActive(true);

            ayrýca burada oluþturulan enemyObject'in rigitbody'sine ulaþýp kinematic'de yapmak gerekiyor
            */



            //Böyle uðraþmaktansa prefab kullanalým prefab nesnemizin içinde tüm bu componentler olsun tek tek her düþman oluþturduðumuzda Mover EnemyController gibi þeyleri eklemek zorunda kalmayalým.

            /* Instantiate(enemy, transform.position, transform.rotation);*/ //Bu bizden oluþturacaðý object'i ister yukarýda oluþturduðumuz ve içine prefabýný attýðýmýz enemy nesnesini pozisyon ve rotationunu buraya giriyoruz aslýnda boru spawner'ýn ilk konumunu almýþ olduk
                                                                             //Bunun yerine þöyle de yapabiliriz.

            /*Instantiate(enemy , this.transform);*/ //Bunu yaptýðýmýzda mevcut öðenin yani spawner'ýn konumunu almakla kalmýyor spawn edilen öðeleri spawner'ýn hiyarþisi altýnda toplamýþ oluyoruz 

            //zaten verdiðimiz prefabýmýzýn içersinde de bunlarýn hepsi var.


            int randonValue = Random.Range(0, enemies.Length); //4 dahil deðil
            Instantiate(enemies[randonValue], this.transform);
        }


        private void ResetTime()
        {
            _currentSpawnTime = 0f;
        }
        void getTime()
        {
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime); 
        }
    }
}

