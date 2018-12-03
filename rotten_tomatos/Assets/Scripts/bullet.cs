using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public float lifetime;
    private float timeCount;
	// Use this for initialization
	void Start () {
        timeCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timeCount += Time.deltaTime;
        if (timeCount >= lifetime)
        {
            Destroy(gameObject);
        }
		
	}
}
