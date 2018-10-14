using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {
    public GameObject attractedTo;
    public float strengthOfAttraction;

    public Rigidbody rb;

    void OnTriggerEnter(Collider other)
    {
        //Vector3 direction = attractedTo.transform.position - transform.position;
        //rb.AddForce(strengthOfAttraction * direction);
        transform.parent = attractedTo.transform;

    }

    // void OnCollisionEnter(Collider other)
    // {
    //  if (collision.attractedTo.tag == "hand")
    //  {
    //     attractedTo.transform.parent = transform.parent;
    //  }
    //}
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
