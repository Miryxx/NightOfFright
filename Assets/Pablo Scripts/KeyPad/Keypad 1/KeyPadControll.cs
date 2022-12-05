using UnityEngine;

public class KeyPadControll : MonoBehaviour
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
            Destroy(this);
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
