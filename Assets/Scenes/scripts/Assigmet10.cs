using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int n = Multiply(5, i);
            Debug.Log(n);
        }
    }
    public static int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
}
