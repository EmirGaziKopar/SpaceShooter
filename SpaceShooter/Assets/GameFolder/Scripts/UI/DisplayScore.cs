using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    

    TextMeshProUGUI textMesh;
   

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

    }

    private void Start()
    {
        GameManager.Instance.OnscoreChanged += HandleOnScoreChanged;
    }




    private void OnDisable()
    {
        GameManager.Instance.OnscoreChanged -= HandleOnScoreChanged;
    }



    private void HandleOnScoreChanged(int score)
    {
        textMesh.text = $"Score:{score}";




    }
}