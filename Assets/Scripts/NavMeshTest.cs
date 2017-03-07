using UnityEngine;
using System.Collections;

public class NavMeshTest : MonoBehaviour {

    // Use this for initialization
    public Transform target;
    private  GameObject target2;
    private int time;
    private string location;
    UnityEngine.AI.NavMeshAgent agent;
    Animator anim;
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);
        //agent.SetDestination(target.position);
        //prototype
        if (currentState.fullPathHash == Animator.StringToHash("Base Layer.Walk"))
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 3f;
            time = (int)Time.time;
            if(time % 30 == 0)
            {
                location = getWanderPoint();
                target2 = GameObject.Find(location);
            }
           // Debug.Log("Wandering: to" + location);
            agent.SetDestination(target2.GetComponent<Transform>().position);
        }
        else if (currentState.fullPathHash == Animator.StringToHash("Base Layer.Chase"))
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 7f;
            agent.SetDestination(target.position);
        }
        else if (currentState.fullPathHash == Animator.StringToHash("Base Layer.Idle"))
            GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 0f;

	}

    string getWanderPoint()
    {
        int random = (int)Random.Range(1f, 20.9f);
        return "spawnPt" + random.ToString();
    }
}
