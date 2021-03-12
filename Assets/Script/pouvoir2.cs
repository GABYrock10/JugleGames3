using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouvoir2 : MonoBehaviour
{
    public float uMax;
    public float uMin;

    bool isGrowing;

    public float growingSpeed;
    public Transform boutcylindre;
    public GameObject platform;

    bool near;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.F) && near == true)
        {
            if (transform.localScale.x < uMax && isGrowing == true)
            {

                transform.localScale += new Vector3(growingSpeed * Time.deltaTime, 0, 0);
                //transform.position += new Vector3(growingSpeed * Time.deltaTime, 0,0);
                platform.transform.position = new Vector3(boutcylindre.position.x, platform.transform.position.y, platform.transform.position.z);
            }
            else if (transform.localScale.x > uMin && isGrowing == false)
            {
                transform.localScale -= new Vector3(growingSpeed * Time.deltaTime, 0, 0);
                //transform.position -= new Vector3(growingSpeed * Time.deltaTime, 0,0);
                platform.transform.position = new Vector3(boutcylindre.position.x, platform.transform.position.y, platform.transform.position.z);
            }
            
            if (transform.localScale.x >= uMax)
            {
                isGrowing = false;
            }
            else if (transform.localScale.x <= uMin)
            {
                isGrowing = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            near = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            near = false;
        }
    }
}
