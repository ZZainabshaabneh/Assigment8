using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    Player player2 = new Player(); 

    void start()
    {
        player1.InitializePlayer("Ali", 50);
        player2.InitializePlayer("Khalid", 55);
        Debug.Log(player1.playerName);
        player2.ShowPlayerCount();
    }
}
