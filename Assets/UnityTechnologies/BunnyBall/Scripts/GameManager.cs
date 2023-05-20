using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject winnerUI;
    public GameObject player;

    private void Update()
    {
       //is the game over?
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
