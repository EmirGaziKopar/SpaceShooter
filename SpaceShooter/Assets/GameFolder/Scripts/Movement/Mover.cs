using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShooter.Movements
{
    [RequireComponent(typeof(Rigidbody2D))] //Bu class'ý kullanacak nesnenin üzerinde rigitbody olmak zorunda 

    //Yani bu kod sayesinde ya rigitbody otomatik olarak eklenecek ya da hata mesajý alacaðýz ve rigitbody eklememiz gerektiði söylenecek.

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

