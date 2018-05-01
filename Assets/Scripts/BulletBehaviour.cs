using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float accelerationRate = 100f;
    public float maxSpeed = 100f;
    private float speed = 0;

    // Update is called once per frame
    void Update()
    {
        if (speed < maxSpeed)
        {
            speed += accelerationRate * Time.deltaTime;
        }
        else if (speed >= maxSpeed)
        {
            speed = maxSpeed;
        }

        transform.position += transform.forward * speed;
    }
}
