using UnityEngine;

public class KeyPadControll1 : MonoBehaviour
{

    public int correctCombination;
    public bool accessGranted = false;

    //Could be anything else
    public Light spotLight;

    private void Start()
    {
        spotLight.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (accessGranted == true)
        {
            //Do whatever you action you want to take when the user hits the correct key.
            spotLight.enabled = true;
            accessGranted = false;
        }
    }


    public bool CheckIfCorrect(int combination)
    {
        if (combination == correctCombination)
        {
            accessGranted = true;
            return true;
        }
        return false;
    }
}
