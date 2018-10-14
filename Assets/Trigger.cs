using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public GameObject attractedToBlue;
    public float strengthOfAttraction;
    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Transform pos =  other.GetComponent<Transform>();
        pos.setPo
    }

    // Update is called once per frame
    void Update () {
		
	}
}
