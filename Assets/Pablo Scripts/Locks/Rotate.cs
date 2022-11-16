using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotate : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;

    private void Start()
    {
        coroutineAllowed = true;
        numberShown = 5;
    }

    public void Turn()
    {
        if (Input.GetKeyDown("A"))
        {

            if (coroutineAllowed)
            {
                StartCoroutine("RotateWheel");
            }

        }
    }
    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;
        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, 0f, -3f);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineAllowed = true;
        numberShown += 1;

        if (numberShown > 9)
        {
            numberShown = 0;
        }
        Rotated(name, numberShown);
    }
}
