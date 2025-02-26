using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleCounter : MonoBehaviour
{
    void Start()
    {
        UpdateScore(0);
    }

    public TextMeshProUGUI scoreText;
    public float playerScore = 20f;
    public void UpdateScore(float scoreChange)
    {
        playerScore += scoreChange;
        scoreText.text = playerScore.ToString() + " REMAIN";
    }
    
}
