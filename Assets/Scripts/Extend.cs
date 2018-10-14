using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extend : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        if (transform.localScale.z < 8f && name == "extend")
        {
            transform.localScale += new Vector3(0.0f, 0.0f, 0.01f);
            transform.localPosition = new Vector3(0.0f, -0.025f, transform.localScale.z/2);
            
        } 
         if (transform.localScale.z > 0.01f && name == "retract")
           {
                transform.localScale += new Vector3(0.0f, 0.0f, -0.04f);
                transform.localPosition = new Vector3(0.0f, -0.025f, transform.localScale.z / 2);

           }
        
        
	}
}
