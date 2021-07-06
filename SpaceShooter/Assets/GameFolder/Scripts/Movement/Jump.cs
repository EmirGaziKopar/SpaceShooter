using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Movements
{

    public class Jump : MonoBehaviour
    {
        [SerializeField] float forceCoefficient = 300f;

        public float JumpForce
        {
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

        public void jumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;

            rigidbody2D.AddForce(Vector2.up * forceCoefficient);
        }
    }
}


