using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGunChoicePlayer : MonoBehaviour
{
    public GameObject pistol;
    public GameObject MG;

    private void Awake()
    {
        //instantiating gun at beginning of level based on button click
        //destroying placeholder after gun replaces it
        if (MainMenu.whichGun == "Pistol")
        {
            Instantiate(pistol, transform.position, Quaternion.identity);
            pistol.transform.parent = gameObject.transform;
            Destroy(gameObject);
        }
        if (MainMenu.whichGun == "MG")
        {
            Instantiate(MG, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
