using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public static int time;

    Text text;
    
	
    void Awake()
    {
        text = GetComponent<Text>();
        time = 60;
    }
	// Update is called once per frame
	void Update () {
        text.text = "" + time;
	}
}
