using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Camera2 : MonoBehaviour {

    public GameObject attachTo;
    public Vector3 offset;

    // Use this for initialization
    void Start()
    {
        transform.LookAt(attachTo.transform.position);
        transform.position = attachTo.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(attachTo.transform.position);
        transform.position = Vector3.Lerp(transform.position, attachTo.transform.position + offset, Time.deltaTime);
    }
}
