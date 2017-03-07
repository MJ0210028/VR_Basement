using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.transform.name);
    }
}
