using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneForPlayer : MonoBehaviour
{

    /* invisible plane on the player's level, for raycasting purposes. 
     * Incredibly hacky way to do it, as it required putting the player on "Transparent FX" layer. 
     * Everything seems to work, but if there's wierd issues it may be from this
     */

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;

    }
}
