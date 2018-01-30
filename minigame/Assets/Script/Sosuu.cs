using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sosuu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("デバッグログ");
        SosuuOut();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SosuuOut()
    {
        for(int num = 1; num <= 101; num++)
        {
            for(int num2 = 2; num2 < num; num2++)
            {
                if(num % num2 == 0)
            }
        }
    }
}
