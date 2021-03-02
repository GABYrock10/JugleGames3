using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public float zoom;

    public float x0ffset;
    public float Y0ffset;
    public float follwSpeed;


    cameraController camController;

    void Start()
    {
        camController = FindObjectOfType<cameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            camController.zoom = zoom;
            camController.x0ffset = x0ffset;
            camController.y0ffset = Y0ffset;
            camController.FollwSpeed = follwSpeed;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            camController.zoom = camController.DefaultZoom;
            camController.x0ffset = camController.Defaultx0ffset;
            camController.y0ffset = camController.Defaulty0ffset;
            camController.FollwSpeed = camController.DefaultFollowSpeed;
        }
    }
}
