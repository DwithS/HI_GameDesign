using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuageManager : MonoBehaviour {

    public Slider speechGuageSlider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    public void doSomething()
    {
        speechGuageSlider.value += 0.11f;
    }
}
