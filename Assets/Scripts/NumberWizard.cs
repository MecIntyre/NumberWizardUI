﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start ()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }
 
    public void OnPressHigher()
    {
        min = guess +1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess -1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
