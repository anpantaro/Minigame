using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        Debug.Log("デバッグログ");
        FibonacciOut();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FibonacciOut()
    {
        int[] Hairetu = new int[20];
        Hairetu[0] = 0;
        Hairetu[1] = 1;
        for (int num = 1; num <= 19; num++)
        {
            Hairetu[num + 1] = Hairetu[num] + Hairetu[num - 1];
            Debug.Log()
        }
    }
}