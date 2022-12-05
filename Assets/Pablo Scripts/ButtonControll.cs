using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonControll : MonoBehaviour
{
    //Sound
    private AudioSource source;
    public AudioClip buttonSound;


    public bool on = false;
    private bool buttonHit = false;
    private GameObject button;

    private float buttonDownDistance = 0.025f;
    private float buttonReturnSpeed = 0.001f;
    private float buttonOriginalY;

    public Light spotLight;


    //Button can be hit again timer
    private float buttonHitAgainTime = 0.5f;
    private float canHitAgain;

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        //Get button and position
        button = transform.GetChild(0).gameObject;
        buttonOriginalY = button.transform.position.y;

        //turn off spotlight
        if (spotLight != null)
            spotLight.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(buttonHit == true)
        {
            //playSound
            source.PlayOneShot(buttonSound);

            buttonHit = false;


            //if on is true make on false, if on is false make on true
            on = !on;
            
            //change position
            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - buttonDownDistance, button.transform.position.z);
           if(spotLight != null)
            {
                if (on)
                {
                    spotLight.enabled = true;
                }
                else
                {
                    spotLight.enabled = false;
                }
            }
     

        }

        //return to original position
        if (button.transform.position.y < buttonOriginalY)
        {
            button.transform.position += new Vector3(0, buttonReturnSpeed, 0);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand") && canHitAgain < Time.time)
        {
            canHitAgain = Time.time + buttonHitAgainTime;
            buttonHit = true;
        }
    }
}
