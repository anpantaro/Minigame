using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour {

     
	// Use this for initialization
	void Start () {
        Debug.Log("デバッグログ");
        FizzBuzzOut();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void FizzBuzzOut()
    {

        for (int num = 1; num <= 20; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Debug.Log("Fizz");

            }
            else if (num % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(num);
            }

        }
        
    }
}
