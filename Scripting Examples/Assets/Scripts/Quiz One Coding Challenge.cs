using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public int Health = 100;
    private string PlayerName = "Mr Plunder"; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IncreaseScore()
    {
        Score = Score + 10;
    }

    private void PrintPlayerName()
    {
        Console.WriteLine(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health = Health - 20;
    }
}
