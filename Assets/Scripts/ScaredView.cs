using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class ScaredView : MonoBehaviour {

    private GameObject enemy;
    private float distance;
    public float intensity = 0.001f; //Warning: Do not overpower intensity! Serious
    public float lightintensity = 0.05f;
    public float StunOffset = 0f;
    AnimatorStateInfo ZombieAnim;
	// Use this for initialization
	void Start () {
        enemy = GameObject.Find("ZombieRig");
        lightintensity = 0.03f;
        intensity = 0.008f;
    }
	
	// Update is called once per frame
	void Update () {
        ZombieAnim = GameObject.Find("ZombieRig").GetComponent<ZombieAnimator>().currentState;
        distance = Vector3.Distance(enemy.GetComponent<Transform>().position, GetComponentInParent<Transform>().position);
        //Debug.Log("Light intensity= "+lightintensity);
       // Debug.Log("Distortion value=" + distance * intensity);
       if(distance <= 20f)
        {
            GetComponent<Fisheye>().strengthX = Random.Range(0f, (20-distance) * intensity);
            GetComponent<Fisheye>().strengthY = Random.Range(0f, (20-distance) * intensity);
            GetComponent<Tonemapping>().exposureAdjustment = 1.5f + Random.Range(-(lightintensity * (20-distance)), 0);
            
        }
        else
        {
            GetComponent<Tonemapping>().exposureAdjustment = 1.5f;
            while (GetComponent<Fisheye>().strengthX != 0f && GetComponent<Fisheye>().strengthY != 0f)
            {
                GetComponent<Fisheye>().strengthX = Mathf.Max(0f, GetComponent<Fisheye>().strengthX- 0.005f);
                GetComponent<Fisheye>().strengthY = Mathf.Max(0f, GetComponent<Fisheye>().strengthY - 0.005f);
                
            }
            

        }
        if (ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Hit")) StunOffset = 0.8f;
        else StunOffset = Mathf.Max(StunOffset - Time.deltaTime * 0.3f, 0f);
        GetComponent<MotionBlur>().blurAmount = StunOffset;

    }
}
