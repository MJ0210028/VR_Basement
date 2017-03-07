using UnityEngine;
using System.Collections;

public class jumpScare : MonoBehaviour
{
    public float distance;
    public float angle;
    private GameObject scaryObject;
    // Use this for initialization
    void Start()
    {
        scaryObject = GameObject.Find("ZombieRig");
        StartCoroutine(playsound());
    }

    // Update is called once per frame
    void Update()
    {
        
 
        distance = Vector3.Distance(GameObject.Find("FPSController").transform.position, scaryObject.transform.position);
        angle = GameObject.Find("FPSController").transform.eulerAngles.y - scaryObject.transform.eulerAngles.y;
        if (angle < 0) angle = -angle;
   
    }
    IEnumerator playsound()
    {
        while (true)
        {
            if (distance < 4f && (angle > 145f && angle < 215f))
                {
                    Debug.Log("Found Scare");
                    GetComponent<AudioSource>().Play();
                    yield return new WaitForSeconds(10);

                }
                else Debug.Log("Not scared!");
                yield return new WaitForSeconds(0.1f);
        }
    }
}
