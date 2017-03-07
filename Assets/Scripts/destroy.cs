using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered.");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Left.");
    }
}
