using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Game Manager'a heryerden ulaþmak istediðimiz için namespace vermiyoruz*/
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get;  private set; }

    private void Awake()
    {
        
        SingeltonThisGameObject(); // Bu singelton design patternidir. 
    }

    private void SingeltonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this; // Instance diye bir propery var ve biz ona bu class'ý referance veriyoruz. Bu class'ýn referancesini instance'ye atýyorum 
            DontDestroyOnLoad(this.gameObject); //GameManager'ýn içinde olduðu gameobject'i yok etme demiþ olduk. 

        }
        else
        {

            Destroy(this.gameObject); //GameManager'ýn içinde olduðu ikinci bir obje'de varsa onu yok et demiþ olduk.

        }
    }

    
}
