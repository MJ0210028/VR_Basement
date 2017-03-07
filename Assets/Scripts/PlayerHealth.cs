using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    public float playerHealth = 100.1f;
    private GameObject cameraObject;
    private int playerHealthHash = Animator.StringToHash("playerHealth");
    private int zombieChaseHash = Animator.StringToHash("ZombieIsChasing");
    private float HealthRegenTime;
    private float decay;
    private float currentDistort;
    private float distance;
    public float distortMax = 0.3f;
    Animator anim;
    AnimatorStateInfo ZombieAnim;
    AnimatorStateInfo currentState;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        HealthRegenTime = 0f;
        cameraObject = GameObject.Find("FirstPersonCharacter");
        decay = 0f;
        
        cameraObject.GetComponent<UnityStandardAssets.ImageEffects.MotionBlur>().blurAmount = 0f;
        currentDistort = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("enemy").transform.position);
        ZombieAnim = GameObject.FindGameObjectWithTag("enemy").GetComponent<ZombieAnimator>().currentState;
        anim.SetFloat(playerHealthHash, playerHealth);
        print("Distortion value: " + (15 - (distance >= 15 ? 15 : distance)));
        anim.SetBool(zombieChaseHash, !((ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Walk"))||(ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Idle"))));
        if (playerHealth <= 0)
        {
            playerDeath();
        }
        else
        {
            if(currentState.fullPathHash == Animator.StringToHash("Base Layer.Healing"))
            {
                Debug.Log("Healing");
                HealthRegenTime += Time.deltaTime;
                playerHealth = Mathf.Min((playerHealth + Time.deltaTime*Mathf.Pow(1.17f,HealthRegenTime)), 100.5f);
                currentDistort = Mathf.Lerp(currentDistort, 0f, Time.deltaTime * 0.01f);
            }
            else if(currentState.fullPathHash == Animator.StringToHash("Base Layer.Normal"))
            {
                HealthRegenTime = 0f;
                currentDistort = Mathf.Lerp(currentDistort, 0f, Time.deltaTime * 0.01f);
            }
            else if(currentState.fullPathHash == Animator.StringToHash("Base Layer.Panic"))
            {
                currentDistort = distortMax;
            }

            cameraObject.GetComponent<UnityStandardAssets.ImageEffects.Fisheye>().strengthX = Random.Range(0f, currentDistort * ((15 - (distance >= 15 ? 15 : distance)) / 15f));
            cameraObject.GetComponent<UnityStandardAssets.ImageEffects.Fisheye>().strengthY = Random.Range(0f, currentDistort * ((15 - (distance >= 15 ? 15 : distance)) / 15f));
        }
        
        if (ZombieAnim.fullPathHash == Animator.StringToHash("Base Layer.Hit"))
        {
            decay = 0.02f;
            print("fuck");
            cameraObject.GetComponent<UnityStandardAssets.ImageEffects.MotionBlur>().blurAmount = 0.8f;
        }
        else
        {
            cameraObject.GetComponent<UnityStandardAssets.ImageEffects.MotionBlur>().blurAmount
                = Mathf.Lerp(cameraObject.GetComponent<UnityStandardAssets.ImageEffects.MotionBlur> ().blurAmount, 0f, Time.deltaTime * decay);
            decay *= 1.01f;
        }
	}
    void playerDeath() {
       
    }
}
