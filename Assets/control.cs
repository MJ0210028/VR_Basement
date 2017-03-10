using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    public Light spotLight;
    public bool spotLightOn;
    
    void Start ()
    {
        spotLight = GetComponentInChildren<Light>();
        spotLight.enabled = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            spotLightOn = !spotLightOn;
            spotLight.enabled = spotLightOn;
        }
    }
}
