using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {

    public Light spotLight;
    public bool spotLightOn;

    //initalize the light to open
    void Start ()
    {
        spotLight = GetComponentInChildren<Light>();
        spotLight.enabled = false;
	}
	
    //LIGHT CONTROL TEST. press "L" to open/close the light
    //you don't need this during game play
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.L))
        {
            spotLightOn = !spotLightOn;
            spotLight.enabled = spotLightOn;
        }
	}
}
