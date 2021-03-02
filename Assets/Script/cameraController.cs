using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    GameObject Player;
    public float Defaultx0ffset;
    public float Defaulty0ffset;
    public float DefaultFollowSpeed = 1;
    public float DefaultZoom;


    public float FollwSpeed = 1;
    public float x0ffset;
    public float y0ffset;
    public float zoom;

    private Vector3 Target;

    void Start()
    {
        Player = FindObjectOfType<characterMovement>().gameObject;
        zoom = DefaultZoom;
        x0ffset = Defaultx0ffset;
        y0ffset = Defaulty0ffset;
        FollwSpeed = DefaultFollowSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Target = new Vector3(Player.transform.position.x + x0ffset , Player.transform.position.y + y0ffset, zoom);

        transform.position = Vector3.Lerp(transform.position, Target, FollwSpeed * Time.deltaTime);
    }
}
