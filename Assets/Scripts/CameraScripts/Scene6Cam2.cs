using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6Cam2 : MonoBehaviour {

    public GameObject attachTo;

    private Vector3 localTransform;

    // Use this for initialization
    void Start()
    {
        transform.position = attachTo.transform.position;
        transform.forward = attachTo.transform.forward * -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt((attachTo.transform.position) + (attachTo.transform.forward * 20));
        localTransform = attachTo.transform.position + (attachTo.transform.up) + (attachTo.transform.forward * - 1.5f);
        transform.position = localTransform;
    }
}
