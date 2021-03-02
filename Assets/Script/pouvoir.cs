using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouvoir : MonoBehaviour
{
    public float uMax;
    public float uMin;

    bool isGrowing;

    public float growingSpeed;

    public GameObject platform;

    bool near;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && near == true)
        {
            if(transform.localScale.y < uMax && isGrowing == true)
            {
                
                transform.localScale += new Vector3(0,growingSpeed * Time.deltaTime, 0);
                transform.position += new Vector3(0, growingSpeed * Time.deltaTime, 0);
                platform.transform.position = new Vector3(platform.transform.position.x , transform.position.y + transform.localScale.y , platform.transform.position.z);
            }
            else if(transform.localScale.y > uMin && isGrowing == false)
            {
                transform.localScale -= new Vector3(0,growingSpeed * Time.deltaTime, 0);
                transform.position -= new Vector3(0, growingSpeed * Time.deltaTime, 0);
                platform.transform.position = new Vector3(platform.transform.position.x, transform.position.y + transform.localScale.y , platform.transform.position.z);
            }

            if(transform.localScale.y >= uMax)
            {
                isGrowing = false;
            }
            else if(transform.localScale.y <= uMin)
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
