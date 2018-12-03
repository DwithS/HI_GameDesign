using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public void SceneChange0()
    {
        SceneManager.LoadScene("0_Start");
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("1_test");
    }
}
