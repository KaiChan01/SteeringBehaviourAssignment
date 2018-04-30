using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour {

    public float fallRate = 10f;
    public float maxSpeed = 10f;
    private float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(speed < maxSpeed)
        {
            speed += fallRate * Time.deltaTime;
        }
        else if(speed >= maxSpeed)
        {
            speed = maxSpeed;
        }

        if(transform.position.y < 0.5)
        {
            ParticleSystem exp = GetComponent<ParticleSystem>();
            exp.Play();
            Destroy(gameObject, exp.duration);
        }
        else
        {
            transform.position += Vector3.up * -speed;
        }
	}

}
