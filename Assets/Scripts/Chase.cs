using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {
    public GameObject player;
	// Use this for initialization

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerDirection = new Vector3(transform.position.x - player.transform.position.x,
                                                transform.position.y - player.transform.position.y,
                                                transform.position.z - player.transform.position.z).normalized;
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.transform.position;

        //transform.LookAt(player.transform);
	}
}
