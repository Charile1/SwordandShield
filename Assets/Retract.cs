using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retract : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.z >0.1f && enabled)
        {
            transform.localScale += new Vector3(0.0f, 0.0f, -0.01f);
            transform.localPosition = new Vector3(0.0f, -0.025f, transform.localScale.z / 2);

        }
    }
}
