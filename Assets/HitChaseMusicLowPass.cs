using UnityEngine;
using System.Collections;

public class HitChaseMusicLowPass : MonoBehaviour {
    AnimatorStateInfo ZombieAnim;
    private float SoundRegenTime;
	// Use this for initialization
	void Start () {
        SoundRegenTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        ZombieAnim = GameObject.Find("ZombieRig").GetComponent<ZombieAnimator>().currentState;
        if(ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Hit"))
        {
            GetComponent<AudioLowPassFilter>().cutoffFrequency = 400f;
            SoundRegenTime = 0f;
        }
        else
        {
            SoundRegenTime += Time.deltaTime;
            GetComponent<AudioLowPassFilter>().cutoffFrequency = Mathf.Min(GetComponent<AudioLowPassFilter>().cutoffFrequency
                + Time.deltaTime * Mathf.Pow(5, SoundRegenTime), 22000f);
        }
	}
}
