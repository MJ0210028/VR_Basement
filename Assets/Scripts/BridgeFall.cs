using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeFall : MonoBehaviour {

	private Rigidbody[] rigids;
	// Use this for initialization
	void Start () {
		rigids = GetComponentsInChildren<Rigidbody> ();
		foreach (Rigidbody rigid in rigids) {
			rigid.isKinematic = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if (!other.CompareTag ("Player"))
			return;
		print ("shit");
		foreach (Rigidbody rigid in rigids) {
			rigid.isKinematic = false;
		}
	}

}
