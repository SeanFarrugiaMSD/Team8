﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    int startingPlayerHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        if(sceneName == "Level_01")
        {
            ResetGameDataValues();
            Debug.Log("Coins: " + GameData.Coins);
            Debug.Log("Health: " + GameData.PlayerHealth);
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //EditorApplication.Exit(0);
        Application.Quit();
    }

    public void AddCoins(int coinsToAdd)
    {
        GameData.Coins += coinsToAdd;
        Debug.Log("Coins: " + GameData.Coins);
        UpdateUI();
    }

    public void UpdateUI()
    {
        //Update In-Game UI
    }

    public void ResetGameDataValues()
    {
        GameData.Coins = 100;
        GameData.PlayerHealth = startingPlayerHealth;
    }

    public void ChangePlayerHealth(int amountToChange)
    {
        Debug.Log("Health Before: " + GameData.PlayerHealth);
        GameData.PlayerHealth += amountToChange;
        Debug.Log("Health After: " + GameData.PlayerHealth);
        CheckRageMode();
    }

    //Functionality 10
    public void CheckRageMode()
    {
        if(GameData.PlayerHealth <= (startingPlayerHealth * 0.3))
        {
            //Enable Rage Mode
        }
    }
}