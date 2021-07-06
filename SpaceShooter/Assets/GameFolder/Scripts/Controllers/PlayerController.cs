using SpaceShooter.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShooter.Controllers // Heryerden eriþilmesini engeller 
{
    

    public class PlayerController : MonoBehaviour
    {

        Jump jump;
        PcInput pcInput;


        bool isleftMouseClicked;
        

        
       

        Rigidbody2D _rigidbody2D; // This is a private field , fields can be accessed from anywhere in the class

        //Awaket run Before Start -> Awake OnEnable Reset Start FixedUpdate 
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>(); // Ýçinde bulunduðu nesneye referans vermesini saðlar
            jump = GetComponent<Jump>();

            pcInput = new PcInput();


        }
        // Start is called before the first frame update
        void Start()
        {

        }

        void Update()
        {
            if (pcInput.leftClick)
            {
                isleftMouseClicked = true;
            }
        }

        private void FixedUpdate()
        {
            if(isleftMouseClicked)
            {

                jump.jumpAction(_rigidbody2D); // Jump sýnýfýndan oluþturduðumuz referans deðer sayesinde ve içeriðe ulaþmak için oluþturduðumuz  getComponent sayesinde methodu kullandýk.

                isleftMouseClicked = false;

            }
            
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            /*
             Bu kod çalýþmadý 
            if (collision.gameObject.tag == "Planet")
            {
                GameManager.Instance.RestartGame();
            }
              

             */

            GameManager.Instance.RestartGame();
            
        }
    }
}


