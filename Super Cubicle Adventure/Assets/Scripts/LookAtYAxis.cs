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
    public Camera cam;
    public MovesLeft movesScript;


    // Update is called once per frame


    void Update()
    {
        int moves = movesScript.moves;

        int layerMask = 1 << 8;
        force = (speed * slider.value);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Input.GetMouseButtonUp(0) && (moves > 0) && (slider.value > .2))//if there are moves left and the mouse button was held down for longer than 1/10th second 
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log("look at y axis");
                rb.AddExplosionForce(force, new Vector3(hit.point.x, rb.position.y, hit.point.z), 9999, 0);
            }
        }  
    }
}
