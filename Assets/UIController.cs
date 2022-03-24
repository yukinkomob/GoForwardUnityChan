using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    private GameObject gameOverText;
    private GameObject runLengthText;
    private float len = 0;
    private float speed = 5f;
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }
    }

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}
