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

        
        if (Physics.Raycast(ray, out hit))
        {
            //making the ball swivel so it's pointing at the camera, will be needed if rb.AddExplosionForce is changed to something non-directional
            //rb.transform.LookAt(hit.point);

            //applying force to ball, angle and power depend on how close to it you click
            if (Input.GetMouseButtonDown(0))
            {
                rb.AddExplosionForce(speed, new Vector3(hit.point.x, rb.position.y, hit.point.z), distance, 0);
            }

        }


    }
}
