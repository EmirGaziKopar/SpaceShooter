using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShooter.Movements
{
    [RequireComponent(typeof(Rigidbody2D))] //Bu class'� kullanacak nesnenin �zerinde rigitbody olmak zorunda 

    //Yani bu kod sayesinde ya rigitbody otomatik olarak eklenecek ya da hata mesaj� alaca��z ve rigitbody eklememiz gerekti�i s�ylenecek.

    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }


        private void Start()
        {
            _rigidbody2D.velocity = Vector2.left * moveSpeed; //x=-1 y=0
        }

    }
}

