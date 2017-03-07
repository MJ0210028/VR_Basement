using UnityEngine;
using System.Collections;
using ui = UnityEngine.UI;

public class StartGame : MonoBehaviour {
    private ui.Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<UnityEngine.UI.Text>();
        StartCoroutine(vanish());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator vanish() {
        yield return new WaitForSeconds(7f);
        text.enabled = false;
    }
}
