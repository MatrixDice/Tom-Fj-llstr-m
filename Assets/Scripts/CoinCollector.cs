using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // Create 3 new gameobjects (the small coins)
    [SerializeField] GameObject[] coinObjects = new GameObject[3];

    int coins = 0; // public int if accessible everywhere

    public void AddCoin() 
    {
        // Do not count more than 3 coins
        if (coins < 3)
        {
            // Set the small coins to active (inactive from beginning) 
            //   so they get visible
            coinObjects[coins].SetActive(true);
            coins++;
        }
    }
}
