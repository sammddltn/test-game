using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    public GameObject endLevel;
    public GameObject player;

    // Update is called once per frame
    public void EndLevelScreen()
    {
        endLevel.SetActive(true);
        player.SetActive(false);
    }
}
