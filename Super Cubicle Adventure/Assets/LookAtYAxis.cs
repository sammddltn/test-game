 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtYAxis : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float distance;
    public Slider slider;
    public float force;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        force = (speed * slider.value);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            //making the ball swivel so it's pointing at the camera, will be needed if rb.AddExplosionForce is changed to something non-directional
            //rb.transform.LookAt(hit.point);

            //applying force to ball, angle and power depend on how close to it you click
            if (Input.GetMouseButtonUp(0))
            {
                //rb.AddForce(transform.forward * -force, ForceMode.VelocityChange);
                rb.AddExplosionForce(force, new Vector3(hit.point.x, rb.position.y, hit.point.z), 9999, 0);
            }

        }


    }
}
