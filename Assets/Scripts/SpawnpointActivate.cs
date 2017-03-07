using UnityEngine;
using System.Collections;

public class SpawnpointActivate : MonoBehaviour {
    public int trigger=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        switch (gameObject.name)
        {
            case "spawnPt1":
                transform.parent.GetComponent<Spawn>().spawnReq = 1;
                Debug.Log("Walked pass spawn point 1");
                break;
            case "spawnPt2":
                transform.parent.GetComponent<Spawn>().spawnReq = 2;
                Debug.Log("Walked pass spawn point 2");
                break;
            case "spawnPt3":
                transform.parent.GetComponent<Spawn>().spawnReq = 3;
                Debug.Log("Walked pass spawn point 3");
                break;
            case "spawnPt4":
                transform.parent.GetComponent<Spawn>().spawnReq = 4;
                Debug.Log("Walked pass spawn point 4");
                break;
            case "spawnPt5":
                transform.parent.GetComponent<Spawn>().spawnReq = 5;
                Debug.Log("Walked pass spawn point 5");
                break;
            case "spawnPt6":
                transform.parent.GetComponent<Spawn>().spawnReq = 6;
                Debug.Log("Walked pass spawn point 6");
                break;
            case "spawnPt7":
                transform.parent.GetComponent<Spawn>().spawnReq = 7;
                Debug.Log("Walked pass spawn point 7");
                break;
            case "spawnPt8":
                transform.parent.GetComponent<Spawn>().spawnReq = 8;
                Debug.Log("Walked pass spawn point 8");
                break;
            case "spawnPt9":
                transform.parent.GetComponent<Spawn>().spawnReq = 9;
                Debug.Log("Walked pass spawn point 9");
                break;
            case "spawnPt10":
                transform.parent.GetComponent<Spawn>().spawnReq = 10;
                Debug.Log("Walked pass spawn point 10");
                break;
            case "spawnPt11":
                transform.parent.GetComponent<Spawn>().spawnReq = 11;
                Debug.Log("Walked pass spawn point 11");
                break;
            case "spawnPt12":
                transform.parent.GetComponent<Spawn>().spawnReq = 12;
                Debug.Log("Walked pass spawn point 12");
                break;
            case "spawnPt13":
                transform.parent.GetComponent<Spawn>().spawnReq = 13;
                Debug.Log("Walked pass spawn point 13");
                break;
            case "spawnPt14":
                transform.parent.GetComponent<Spawn>().spawnReq = 14;
                Debug.Log("Walked pass spawn point 14");
                break;
            case "spawnPt15":
                transform.parent.GetComponent<Spawn>().spawnReq = 15;
                Debug.Log("Walked pass spawn point 15");
                break;
            case "spawnPt16":
                transform.parent.GetComponent<Spawn>().spawnReq = 16;
                Debug.Log("Walked pass spawn point 16");
                break;
            case "spawnPt17":
                transform.parent.GetComponent<Spawn>().spawnReq = 17;
                Debug.Log("Walked pass spawn point 17");
                break;
            case "spawnPt18":
                transform.parent.GetComponent<Spawn>().spawnReq = 18;
                Debug.Log("Walked pass spawn point 18");
                break;
            case "spawnPt19":
                transform.parent.GetComponent<Spawn>().spawnReq = 19;
                Debug.Log("Walked pass spawn point 19");
                break;
            case "spawnPt20":
                transform.parent.GetComponent<Spawn>().spawnReq = 20;
                Debug.Log("Walked pass spawn point 20");
                break;
        }
        trigger = 1;
        transform.parent.GetComponent<Spawn>().spawnPlease = true;

    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player left trigger.");
        trigger = 0;
    }
}
