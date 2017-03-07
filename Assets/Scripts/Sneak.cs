using UnityEngine;
using System.Collections;

public class Sneak : MonoBehaviour {
    private Spawn spawn;
    public float speed=2.0f;
    void Awake ()
    {
        spawn = GameObject.Find("EnemySpawn").GetComponent<Spawn>();
    }
	// Use this for initialization
	void Start () {
       // Vector3 Move0 = new Vector3(0, 0, 1);
        //speed = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
        /*float viewAngle = GameObject.Find("FPSController").GetComponent<Transform>().eulerAngles.y;
        switch (spawn.spawnPoint[1])
        {
            case 0:
                if (viewAngle < 225f || viewAngle > 315f)
                    transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
                else
                    transform.Translate(Vector3.zero, Space.World);
                break;
            case 1:
                if (viewAngle < 315f && viewAngle > 45f)
                    transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
                else
                    transform.Translate(Vector3.zero, Space.World);
                break;
            case 2:
                if (viewAngle < 45f || viewAngle > 135f)
                    transform.Translate(Vector3.forward * Time.deltaTime * speed*-1f, Space.World);
                else
                    transform.Translate(Vector3.zero, Space.World);
                break;
        }
	 */
      
	}

}
