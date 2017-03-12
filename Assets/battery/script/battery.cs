using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battery : MonoBehaviour {

    public Scrollbar bbattery;
    public float juice = 100;
    public Text textref;
    public int max = 10;
    public static battery Instance;

    void Start()
    {

        Instance = this;
        textref.text = max.ToString();

    }


   	void Update ()
    {
        GameObject thespotlight = GameObject.FindGameObjectWithTag("Spotlight");
        light ll = thespotlight.GetComponentInChildren<light>();

        //press "R" to recharge 
        if (Input.GetKeyDown(KeyCode.R) && (max != 0) && (juice < 50))
        {
            juice = 100;
            ll.spotLight.enabled = true;
            max -= 1;
            textref.text = max.ToString();
        }

        
        if (juice >= 10)
        {
            //battery juice will automatically decrease when the time past
            float timepast = Time.deltaTime;
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

    public void pickBattery()
    {
        max += 1;
        textref.text = max.ToString();
    }
    
}
