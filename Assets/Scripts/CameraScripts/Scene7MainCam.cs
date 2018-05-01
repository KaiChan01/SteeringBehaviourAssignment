using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7MainCam : MonoBehaviour {

    public GameObject attachTo;

    // Use this for initialization
    void Start()
    {
        transform.LookAt(attachTo.transform.position);
        transform.position = attachTo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(attachTo.transform.position);
        Vector3 localTransform = attachTo.transform.position + (attachTo.transform.up * 5) + (attachTo.transform.forward * 10f);
        transform.position = localTransform;
    }
}
