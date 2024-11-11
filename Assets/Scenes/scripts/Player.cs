using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    public string playerName = "";
    public int health = 0;
    public static int palyerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        palyerCount++;

    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(health);
    }
    public void Heal(int amount, bool fullRestore)
    {
        if (fullRestore)
        {
            health = 0;
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log(palyerCount);
    }
}
