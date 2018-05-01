using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour {

    public GameObject bullet;

    public float fireRate;
    public int cooldown;
    public int fireDuration;

    private bool fireToggle = false;
    private bool leftRightToggle = true;
    private float elapsed;
    private float bulletTimeElasped;

	// Use this for initialization
	void Start () {
        elapsed = 0;
        bulletTimeElasped = fireRate;
    }

    // Update is called once per frame
    void Update() {
        if (fireToggle)
        {
            elapsed += Time.deltaTime;
            bulletTimeElasped += Time.deltaTime;
            if (bulletTimeElasped >= fireRate)
            {
                Vector3 firingPosition;
                if(leftRightToggle)
                {
                    firingPosition = transform.position + (transform.right * 2) + (transform.forward * 2);
                }
                else
                {
                    firingPosition = transform.position + (transform.right * -2) + (transform.forward * 2);
                }

                Instantiate(bullet, firingPosition, transform.rotation);

                bulletTimeElasped = 0;
                leftRightToggle = !leftRightToggle;
            }
            
            if(elapsed > fireDuration)
            {
                fireToggle = false;
                elapsed = 0;
            }
        }
        else
        {
            elapsed += Time.deltaTime;
            if(elapsed > cooldown)
            {
                fireToggle = true;
                bulletTimeElasped = fireRate;
                elapsed = 0;
            }
        }
	}
}
