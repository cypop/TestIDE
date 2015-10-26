using UnityEngine;
using System.Collections;

public class BallControler : MonoBehaviour {

    public float speedFwd = 1;
    public float speedRight = 1;

    // Use this for initialization
    void Start () {
    
  
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Axe vert" + Input.GetAxis("Vertical"));

        GetComponent<Rigidbody>().AddForce(Vector3.forward * Input.GetAxis("Vertical") * -20);
        GetComponent<Rigidbody>().AddForce(Vector3.left * Input.GetAxis("Horizontal") * 20);

	}
}
