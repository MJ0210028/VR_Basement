using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battery : MonoBehaviour {

    public Scrollbar bbattery;
    public float juice = 100;
    
   	void Update ()
    {
        GameObject thespotlight = GameObject.FindGameObjectWithTag("Spotlight");
        light ll = thespotlight.GetComponentInChildren<light>();
        
        //press "R" to recharge
        if(Input.GetKeyDown(KeyCode.R))
        {
            juice = 100;
            ll.spotLight.enabled = true;
        }

        
        if (juice >= 10)
        {
            //battery juice will automatically decrease when the time past
            float timepast = Time.deltaTime * 10;
            juice -= timepast;
            bbattery.size = juice / 100f;

            //flash light effect  
            if ((juice >= 10) && (juice <= 30))
            {
                ll.spotLightOn = !ll.spotLightOn;
                ll.spotLight.enabled = ll.spotLightOn;
            }
        }
        //to make sure the light turns off when running out of juice
        else
            ll.spotLight.enabled = false;
    }
}
