using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssigment : MonoBehaviour
{
    void Start()
    {
        // int number1 = 90;
        // int number2 = 80;
        // Debug.Log(number1 + number2);
        // string name = "zainab";
        // Debug.Log(name);
        // Debug.Log(number1 + 190);
        // Debug.LogWarning("use Upper Case for your name");
        // Debug.LogError("Enter your Full Name");
        // int playerLive = 3;
        // while(playerLive!=0){
        //     if(playerLive==3){
        //         Debug.Log("Many lives");
        //     }
        //     else
        //      if (playerLive == 2)
        //     {

        //     }
        //     else if (playerLive == 1)
        //     {
        //         Debug.Log("The last life!");
        //     }
        //     playerLive--;
        // }
        // Debug.Log("Game Over!");

        int count = 0;
        while (count < 20)
        {
            int num = Random.Range(1, 21);
            if (num == 5) {
            count ++;
             continue;
             }
            if (num == 15) break;
            Debug.Log(num);
            count++;

        }

        string[] funny = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        while (count <= (funny.Length))
        {
            int num = Random.Range(1, 8);
            Debug.Log(funny[num]);
            count++;
        }
    }
}
