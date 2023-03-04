using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coding_Basics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        for (int i = 22; i <= 100; i += 2)
        {
            Debug.Log(i);
        }

        for (int j = 1; j <= 12; j++)
        {
            if (j == 1)
            {
                Debug.Log("January is 1");
            }

            if (j == 2)
            {
                Debug.Log("February is 2");
            }

            if (j == 3)
            {
                Debug.Log("March is 3");
            }

            if (j == 4)
            {
                Debug.Log("April is 4");
            }

            if (j == 5)
            {
                Debug.Log("May is 5");
            }

            if (j == 6)
            {
                Debug.Log("June is 6");
            }

            if (j == 7)
            {
                Debug.Log("July is 7");
            }

            if (j == 8)
            {
                Debug.Log("August is 8");
            }

            if (j == 9)
            {
                Debug.Log("September is 9");
            }

            if (j == 10)
            {
                Debug.Log("October is 10");
            }

            if (j == 11)
            {
                Debug.Log("November is 11 - MY BIRTHDAY MONTH! YAY!\n");
                for (int o = 1; o <= 30; o++)
                {
                    if (o == 23)
                    {
                        Debug.Log("My BirthDay is on November 23rd!!!\n");
                    }
                    else
                    {
                        Debug.Log(o);
                    }

                }
            }

            if (j == 12)
            {
                Debug.Log("December is 12");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
