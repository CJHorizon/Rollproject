using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
    }

    public int GetScore()
    {
        return score;
    }
    public void SetScore(int newScore)
    {
        score = newScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
