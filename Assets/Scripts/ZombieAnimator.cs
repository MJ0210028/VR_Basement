using UnityEngine;
using System.Collections;

public class ZombieAnimator : MonoBehaviour {
    Animator anim;
    public GameObject FPS;
    public float zombieViewDistance = 15f;
    private float distance;
    private bool damageEnable = true;
    private int time =0;
    //public bool isTouching;
    public AnimatorStateInfo currentState;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(FPS.transform.position, transform.position);
        anim.SetFloat("distance", distance);
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        anim.SetBool("playerInSight", playerIsInSight());
        if (currentState.fullPathHash == Animator.StringToHash("Base Layer.Hit") && damageEnable)
        {
            damageEnable = false;
            Debug.Log("hit!");
            GameObject.Find("FPSController").GetComponent<PlayerHealth>().playerHealth -= 10;
            time = (int)Time.time; //records last time damageEnable has been turned off
        }
        if ((int)Time.time - time > 1)
        {
            damageEnable = true;
        }
    }


    bool playerIsInSight()
    {
        Vector3 target = FPS.transform.position;
        Debug.DrawRay(transform.position, (target - transform.position).normalized * zombieViewDistance);
        Debug.DrawRay(transform.position, transform.forward, Color.yellow);
//        print(Vector3.Dot(transform.forward, (target - transform.position).normalized));
        if (!Physics.Linecast(transform.position, target, 9) &&
            distance < zombieViewDistance &&
            Vector3.Dot(transform.forward, (target - transform.position).normalized) > 0.1)
            return true;
        return false;

    }

}
