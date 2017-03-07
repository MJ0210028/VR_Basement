using UnityEngine;
using System.Collections;

public class BatteryLight : MonoBehaviour {

    public float rechargeTime; //Time of last recharge
    public float onTime; //(Tracking) How long the light has been on
    private Light lt;
    private bool lowpower;
    public float flash; //(Tracking) Random flash variable
    private float lowPowerIntensity;
    //private float lowPowerRange;
    private float chargedPowerIntensity;
    private float chargedPowerRange;
    public float lowPowerAfter; //How long the light should stay with full power

    // Use this for initialization
    void Start () {
        rechargeTime = 0;
        lt = GetComponent<Light>();
        chargedPowerIntensity = lt.intensity;
        chargedPowerRange = lt.range;
        lowpower = false;
	}
	
	// Update is called once per frame
	void Update () {
        onTime = Time.time-rechargeTime;
        if (onTime > lowPowerAfter && lowpower == false)
        {

            lt.intensity = lt.intensity * 0.3f;
            lowPowerIntensity = lt.intensity;
            lt.range = lt.range * 0.5f;
            lowpower = true;
        }

        else if (onTime < lowPowerAfter && lowpower == true)
        {
            lowpower = false;
            lt.intensity = chargedPowerIntensity;
            lt.range = chargedPowerRange;
        }
        if (lowpower == true)
        {
            flash = Random.value;
            if (flash > 0.89f && flash < 0.9f) lt.intensity = chargedPowerIntensity;
            else if (flash > 0.1f && flash < 0.13f) lt.intensity = 0f;
            else lt.intensity = lowPowerIntensity;
        }
	}

}
