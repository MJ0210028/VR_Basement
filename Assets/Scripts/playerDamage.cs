using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerDamage : MonoBehaviour {
    private RawImage thisImage;
    public float StunOffset = 0f;
    AnimatorStateInfo ZombieAnim;
	// Use this for initialization
	void Start () {
        thisImage = GetComponent<RawImage>();
    }
	
	// Update is called once per frame
	void Update () {
        ZombieAnim = GameObject.FindGameObjectWithTag("enemy").GetComponent<ZombieAnimator>().currentState;
     
        Color tmp;
        if (ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Hit")) StunOffset = 0.6f;
        else StunOffset = Mathf.Lerp(StunOffset, 0f, Time.deltaTime * 0.3f);
        
        tmp.a = (100 - GameObject.Find("FPSController").GetComponent<PlayerHealth>().playerHealth) * 0.01f +StunOffset;
        tmp.r = thisImage.color.r;
        tmp.g = thisImage.color.g;
        tmp.b = thisImage.color.b;
        thisImage.color = tmp;


    }
}
