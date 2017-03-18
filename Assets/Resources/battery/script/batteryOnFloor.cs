using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryOnFloor : MonoBehaviour {

	private Color _glowColor = new Color(0.4170057f, 0.3920848f, 0.7205882f, 1f);
	private Renderer _renderer;
	private void Start()
	{
		_renderer = GetComponent<Renderer> ();
	}

	private void Update()
	{
		_renderer.material.SetColor ("_EmissionColor", Color.Lerp (Color.black, _glowColor, Mathf.PingPong(Time.time, 1)));
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            battery.Instance.pickBattery();
        }
    }
}
