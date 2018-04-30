using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Camera : MonoBehaviour {

    public GameObject attachTo;
    public Vector3 offset;

    // Use this for initialization
    void Start()
    {
        transform.position = attachTo.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = attachTo.transform.forward;
        transform.rotation = attachTo.transform.rotation;
        transform.position = Vector3.Lerp(transform.position, attachTo.transform.position + offset, Time.deltaTime * 10);
    }
}
