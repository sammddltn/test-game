using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > 0.1)
        {
            cam.SetActive(true);
        }
        else
        {
            cam.SetActive(false);
        }
    }
}

