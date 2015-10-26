using UnityEngine;
using System.Collections;

public class SonDeCollisionDesQuilles : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() { }

        void OnCollisionEnter(Collision collision) { 

            AudioSource audio = GetComponent<AudioSource>();

        if (audio)
        {
            audio.Play();
            audio.volume = Mathf.Min(collision.relativeVelocity.magnitude / 10.0f, 1.0f);
        }
        
        }
}
