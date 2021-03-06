using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToLvl2 : MonoBehaviour
{
    GameManager myGameManager;

    // Start is called before the first frame update
    void Start()
    {
        myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "playerObject")
        {
            GameData.Alvl1Health = GameData.PlayerHealth;
            GameData.Alvl1Coins = GameData.Coins;
            GameData.Alvl1AssaultAmmo = GameData.AssaultAmmo;
            GameData.Alvl1HandAmmo = GameData.HandAmmo;

            myGameManager.changeScene("Level_02");
        }
    }
}
