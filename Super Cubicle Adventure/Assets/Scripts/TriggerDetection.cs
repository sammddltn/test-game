using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerDetection : MonoBehaviour
{

    public UnityEvent onPlayerEnter;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            onPlayerEnter.Invoke();
    }
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
