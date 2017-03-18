using UnityEngine;
using System.Collections;

public class chaseMusic : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GameObject.Find("ZombieRig").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);
        if(currentState.fullPathHash == Animator.StringToHash("Base Layer.Chase") || currentState.fullPathHash == Animator.StringToHash("Base Layer.Attack"))
        {
            if (GetComponent<AudioSource>().isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
                
            }
            GetComponent<AudioSource>().volume = 1.0f;
            GameObject.Find("BGM").GetComponent<AudioSource>().volume = Mathf.Max(0f, GameObject.Find("BGM").GetComponent<AudioSource>().volume - 0.005f);
            if (GameObject.Find("BGM").GetComponent<AudioSource>().volume == 0f)
            {
                GameObject.Find("BGM").GetComponent<AudioSource>().Pause();
            }
        }
        else
        {
            GetComponent<AudioSource>().volume = Mathf.Max(0f, GetComponent<AudioSource>().volume - 0.005f);
            if (GetComponent<AudioSource>().volume == 0f) GetComponent<AudioSource>().Stop();
            if (GameObject.Find("BGM").GetComponent<AudioSource>().isPlaying == false)
                GameObject.Find("BGM").GetComponent<AudioSource>().Play();
            GameObject.Find("BGM").GetComponent<AudioSource>().volume = Mathf.Min(1f, GameObject.Find("BGM").GetComponent<AudioSource>().volume + 0.05f);
        }
	}
}
