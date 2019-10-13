using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShot : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetMouseButtonDown(0)) {
            Vector3 clickPosition = -Vector3.one;
            

            //clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,5f));
            
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            //if(Physics.Raycast(ray, out hit)) {
            //    clickPosition = hit.point;
            //}

            Plane plane = new Plane(Vector3.up, 0f);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distanceToPlane;

            if(plane.Raycast(ray, out distanceToPlane)) {
                clickPosition = ray.GetPoint(distanceToPlane);
            }

            rb.AddExplosionForce(force, clickPosition, 9999, 0);

            Debug.Log(clickPosition);
        }
    
        
    }
    
}
