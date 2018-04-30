using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTarget : MonoBehaviour {
    public GameObject bomb;
    public GameObject target;
    private Vector3 bombingPosition;
    public float bombingRadius;
    private float yValue;

    public int bombCooldown;
    float elapsed;
    bool bombAvailable;

    // Use this for initialization
    void Start () {
        bombAvailable = true;
    }
	
	// Update is called once per frame
	void Update () {
        bombingPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        if (Vector3.Distance(transform.position, bombingPosition) < bombingRadius && bombAvailable)
        {
            Instantiate(bomb, transform.position - new Vector3(0, 2, 0), transform.rotation);
            bombAvailable = false;
            elapsed = 0;
        }

        if(!bombAvailable)
        {
            elapsed += Time.deltaTime;
            if(elapsed > bombCooldown)
            {
                bombAvailable = true;
            }
        }
	}
}
