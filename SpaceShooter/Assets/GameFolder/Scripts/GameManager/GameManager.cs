using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Game Manager'a heryerden ula?mak istedi?imiz i?in namespace vermiyoruz*/
public class GameManager : MonoBehaviour
{
    [SerializeField] int score;

    public static GameManager Instance { get;  private set; }


    public event System.Action<int> OnscoreChanged; //Score'u ta??mak i?in event kullan?caz

    private void Awake()
    {
        
        SingeltonThisGameObject(); // Bu singelton design patternidir. 
    }

    private void SingeltonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this; // Instance diye bir propery var ve biz ona bu class'? referance veriyoruz. Bu class'?n referancesini instance'ye at?yorum yani art?k null de?il 
            DontDestroyOnLoad(this.gameObject); //GameManager'?n i?inde oldu?u gameobject'i yok etme demi? olduk. 

        }
        else
        {

            Destroy(this.gameObject); //GameManager'?n i?inde oldu?u ikinci bir obje'de varsa onu yok et demi? olduk.

        }
    }


    public void RestartGame()
    {
        StartCoroutine(RestartGameAsync());
    }

    public void IncreaseScore()
    {
        OnscoreChanged?.Invoke(score); //Event doluysa ve score alm??sa 
        score++;

    }

    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("GameMain"); //yield return - > Bu method bittikten sonra ?al??maya devam edecek. 
    }


    
}
