using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculation : MonoBehaviour
{
    float firstNo;
    float secondNo;
    float sumNow;
    float evenSum;

    private void Start()
    {
        firstNo = 1;
        secondNo = 2;

        do
        {
            if (secondNo % 2 == 0)
            {
                evenSum += secondNo;
            }

            sumNow = firstNo + secondNo;
            firstNo = secondNo;
            secondNo = sumNow;



        } while (secondNo < 4000000);

        Debug.Log(evenSum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
