using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public float middle;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        transform.position = player.position + offset;

        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //making the chair swivel so it's pointing at the camera
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Vector3 temp = new Vector3(hit.point.x, (player.position.y + offset.y), hit.point.z);
                transform.LookAt(temp);
                transform.Rotate(0, 180, 0);


            }


        }





    }
}
