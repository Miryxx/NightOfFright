using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTimer : MonoBehaviour
{
    [SerializeField] private float killTimer = 360.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }


    void Timer()
    {
        if (killTimer > 0)
        {
            killTimer -= Time.deltaTime;
            if (killTimer <= 0.01f)
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
