using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public static string correctCode = "5683";
    public static string playerCode = "";

    public static int totalDigits = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode);
        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct!");
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("Wrong. Try Again.");
            }
        }
    }

    public void NumberOne()
    {
        playerCode += "1";
        totalDigits += 1;
    }
}
