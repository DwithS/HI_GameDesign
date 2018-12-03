using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act : MonoBehaviour {

    public float projectileSpeed;

    public bool isOkToShoot;
    const float basicShootDelay = 3f;
    float shootTimer;
    private float delayVariation;
    private float probable_error_max = 2.0f;

    GameObject tomatoPrefab;

    // Use this for initialization
    void Start () {
        tomatoPrefab = Resources.Load("prefabs/Tomato") as GameObject;
        isOkToShoot = true;
        shootTimer = 0;
        delayVariation = Random.Range(-2.0f,2.0f);
}
	
	// Update is called once per frame
	void Update () {


        ShootControl();
    }

    Vector3 setDestination()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 dest = player.transform.position - transform.position;

        dest += new Vector3(Random.Range(probable_error_max * (-1), probable_error_max * 1), Random.Range(probable_error_max * (-1), probable_error_max * 1), Random.Range(probable_error_max * (-1), probable_error_max * 1));

        dest += new Vector3(0, 7, 0);

        Debug.Log("Destination = "+ dest);
        
        return dest;
    }

    void ShootControl() // 발사를 관리하는 함수 입니다.
    {
        if (isOkToShoot) // 쏠 수 있는 상태인지 검사합니다.
        {
            if (shootTimer> basicShootDelay + delayVariation) //쿨타임이 지났는지 검사합니다.
            {
                OnFire();
                Debug.Log("Shots Fired");

                delayVariation = Random.Range(0.0f, 2.0f);

                shootTimer = 0; //쿨타임을 다시 카운트 합니다.
            }
            shootTimer += Time.deltaTime; //쿨타임을 카운트 합니다.
        }
    }


    void OnFire()
    {
        if (true)
        {
            //GameObject PJ = Instantiate(Tomato) as GameObject;
            
            GameObject PJ = Instantiate(tomatoPrefab);

            PJ.GetComponent<Transform>().position = transform.position; // 미사일 위치설정!

            Vector3 movement = new Vector3(0, 0, 0);
            movement = setDestination();

            PJ.GetComponent<Rigidbody>().AddForce(movement * projectileSpeed);


        }
    }

}
