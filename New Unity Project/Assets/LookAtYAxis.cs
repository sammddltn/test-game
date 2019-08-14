 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtYAxis : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //making the chair swivel so it's pointing at the camera
        if (Physics.Raycast(ray, out hit))
        {
            rb.transform.LookAt(hit.point);

            //applying force to chair, angle and power depend on how close to it you click
            if (Input.GetMouseButtonDown(0))
            {
                rb.AddExplosionForce(speed, hit.point, distance, 0);
            }

        }


    }
}
