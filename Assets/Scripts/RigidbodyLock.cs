using UnityEngine;
using System.Collections;

public class RigidbodyLock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 localVelocity = transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity);
        localVelocity.y = 0;
        localVelocity.z = 0;

        GetComponent<Rigidbody>().velocity = transform.TransformDirection(localVelocity);
    }
}
