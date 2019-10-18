using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutofBounds : MonoBehaviour
{
    public GameObject StartPosition; 
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = GameObject.FindWithTag("StartPosition");
        
    }

    void OnTriggerStay(Collider other) {
        Debug.Log("IN WARP ZONE");
        other.gameObject.transform.position = StartPosition.transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
