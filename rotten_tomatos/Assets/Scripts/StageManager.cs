using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

    
    public bool isInStartCountdown=true;
	// Use this for initialization
	void Start () {
        StartCoroutine("StartCountDown");
	}
	
	// Update is called once per frame
	void Update () {
        if (isInStartCountdown)
        {
            return;
        }
	}


    IEnumerator CountDown()
    {
        for (int time = 60; time > 0; time--)
        {
            TimeManager.time = time;
            yield return new WaitForSeconds(1.0f);
        } 
    }

    IEnumerator StartCountDown()
    {
        Text centralText = GameObject.Find("Canvas").transform.Find("Center_Text").GetComponent<Text>();

        for (int f = 3; f >= 1; f -= 1)
        {
            centralText.text = "" + f;
            yield return new WaitForSeconds(1f);
        }
        centralText.text = "START!";


        yield return new WaitForSeconds(1f);
        centralText.enabled = false;

        isInStartCountdown = true;
        StartCoroutine("CountDown");
    }
    
}
