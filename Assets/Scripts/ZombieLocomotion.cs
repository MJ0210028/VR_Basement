using UnityEngine;
using System.Collections;


[RequireComponent (typeof(UnityEngine.AI.NavMeshAgent))]
[RequireComponent (typeof(Animator))]
public class ZombieLocomotion : MonoBehaviour {
    Animator anim;
    UnityEngine.AI.NavMeshAgent agent;
    Vector2 smoothDeltaPosition = Vector2.zero;
    Vector2 velocity = Vector2.zero;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //agent.updatePosition = false;   
	}
	
	// Update is called once per frame
	void Update () {
        /*Vector3 worldDeltaPosition = agent.nextPosition - transform.position;

        float dx = Vector3.Dot(transform.right, worldDeltaPosition);
        float dy = Vector3.Dot(transform.forward, worldDeltaPosition);

        Vector2 deltaPosition = new Vector2(dx, dy);

        float smooth = Mathf.Min(1.0f, Time.deltaTime / 0.15f);
        smoothDeltaPosition = Vector2.Lerp(smoothDeltaPosition, deltaPosition, smooth);

        if (Time.deltaTime > 1e-5f)
            velocity = smoothDeltaPosition / Time.deltaTime;*/
        Vector3 destination = agent.destination - transform.position;

        float dx = Vector3.Dot(transform.right.normalized, destination.normalized);
        float dy = Vector3.Dot(transform.forward.normalized, destination.normalized);

        anim.SetFloat("velX", dx);
        anim.SetFloat("velY", dy);
 
	}
}
