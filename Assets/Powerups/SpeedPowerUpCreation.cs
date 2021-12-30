using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpCreation : MonoBehaviour
{
    public GameObject SpeedPower;
    public float instantiationTime = 20f;
    public float destructionTime = 8f;
    Vector3 worldDim;
    float xPos;
    // Start is called before the first frame update
    void Awake() {
        if (MainMenu.powerMode == false) {
            Destroy(this);
        }
    }
    void Start()
    {
        StartCoroutine(powerupTime());
        
    }

    void createPowerup() {
        GameObject spawn = Instantiate(SpeedPower) as GameObject;
    }

    IEnumerator powerupTime() {
        while(true) {
            yield return new WaitForSeconds(instantiationTime);
            createPowerup();
        }
    }
}
