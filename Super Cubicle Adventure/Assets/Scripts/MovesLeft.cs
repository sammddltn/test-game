using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MovesLeft : MonoBehaviour
{

    public int moves;
    public Text movesLeft;
    public GameObject restartPanel;
    public GameObject player;
    public Rigidbody rb;

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        if (moves <= 0 && player.activeSelf)
        {
            restartPanel.SetActive(true);
        }
        player.SetActive(false);
    }


    void Start()
    {
        movesLeft.text = moves.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && moves > 0)
        {
            moves--;
            movesLeft.text = moves.ToString();
        }


        if (moves <= 0 && player.activeSelf)
        {
            StartCoroutine(Restart());
        }
}
    }
