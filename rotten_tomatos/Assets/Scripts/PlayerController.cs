using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    void FixedUpdate()
    {

        float vertical = Input.GetAxis("Vertical");
        
        float horizontal = Input.GetAxis("Horizontal");
        //Vector3 tempMove = new Vector(vertical, 0, horizontal);
        
        Vector3 tempMove = new Vector3(horizontal, 0, 0);
        transform.Translate(tempMove * 1);
    }
}
