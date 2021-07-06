using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShooter.Controllers // Heryerden eriþilmesini engeller 
{
    

    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float forceCoefficient = 300f;

        public float JumpForce {
            get
            {
                return forceCoefficient;
            }
            set
            {
                if (value > 0 || value < 1000f)
                {
                    forceCoefficient = value;
                }
                else
                {
                    //Hata mesajý gönder
                }
            }
        }
       

        Rigidbody2D _rigidbody2D; // This is a private field , fields can be accessed from anywhere in the class

        //Awaket run Before Start -> Awake OnEnable Reset Start FixedUpdate 
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>(); // Ýçinde bulunduðu nesneye referans vermesini saðlar

        }
        // Start is called before the first frame update
        void Start()
        {

        }


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            { //0 -> left click of mouse 1-> rigth click of mouse 2-> Mid

                _rigidbody2D.AddForce(Vector2.up * forceCoefficient);

                /* up = x=0 y=1 but that's not enought therefore we create a coefficient and multiply with it, and this determines the value of our force.  */
            }
        }
    }
}


