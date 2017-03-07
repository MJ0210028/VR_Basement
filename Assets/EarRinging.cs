using UnityEngine;
using System.Collections;

public class EarRinging : MonoBehaviour {
    AnimatorStateInfo ZombieAnim;
    private float SoundDecayTime;

	// Use this for initialization
	void Start () {
        SoundDecayTime = 0f;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().volume = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        ZombieAnim = GameObject.Find("ZombieRig").GetComponent<ZombieAnimator>().currentState;
        if(ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Hit"))
        {
            
            GetComponent<AudioSource>().volume = 0.7f;
            SoundDecayTime = 0f;
        }
        else SoundDecayTime += Time.deltaTime;
        GetComponent<AudioSource>().volume = Mathf.Max(GetComponent<AudioSource>().volume - Time.deltaTime * 0.01f * Mathf.Pow(1.9f, SoundDecayTime), 0f);

    }
}
