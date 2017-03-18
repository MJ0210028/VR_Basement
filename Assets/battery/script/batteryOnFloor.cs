using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryOnFloor : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            battery.Instance.pickBattery();
        }
    }
}
