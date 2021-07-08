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

       /* EnemyController enemy; *///Tek tuhaf gelen yer buras� EnemyController Bir script ve biz bunun i�ersine bir d��man prefab� att�k. Hem prefab tan�mland� hem'de do�rudan prefab�n i�ersinde yer alan EnemyController �al��t�
        
        [SerializeField]float _currentSpawnTime;
        
        [SerializeField] float _timeBoundary;

        public EnemyController[] enemies;



        private void Start()
        {
            ResetTime();
            getTime();//Oyun her ba�lad���nda d��manlar�n ��k�� zaman�n�n farkl� olmas�n� sa�l�yor 
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime > _timeBoundary )
            {
                getTime(); //Her ad�mda d��manlar�n ��k�� zamn�n�n farkl� olmas�n� sa�l�yor
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

            ayr�ca burada olu�turulan enemyObject'in rigitbody'sine ula��p kinematic'de yapmak gerekiyor
            */



            //B�yle u�ra�maktansa prefab kullanal�m prefab nesnemizin i�inde t�m bu componentler olsun tek tek her d��man olu�turdu�umuzda Mover EnemyController gibi �eyleri eklemek zorunda kalmayal�m.

            /* Instantiate(enemy, transform.position, transform.rotation);*/ //Bu bizden olu�turaca�� object'i ister yukar�da olu�turdu�umuz ve i�ine prefab�n� att���m�z enemy nesnesini pozisyon ve rotationunu buraya giriyoruz asl�nda boru spawner'�n ilk konumunu alm�� olduk
                                                                             //Bunun yerine ��yle de yapabiliriz.

            /*Instantiate(enemy , this.transform);*/ //Bunu yapt���m�zda mevcut ��enin yani spawner'�n konumunu almakla kalm�yor spawn edilen ��eleri spawner'�n hiyar�isi alt�nda toplam�� oluyoruz 

            //zaten verdi�imiz prefab�m�z�n i�ersinde de bunlar�n hepsi var.


            int randonValue = Random.Range(0, enemies.Length); //4 dahil de�il
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

