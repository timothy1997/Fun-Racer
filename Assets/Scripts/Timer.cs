using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;

public class Timer : MonoBehaviour {

    public int timeLeft = 10;
    public Text countDownText;
    public Text player1Score;
    public Text player2Score;
    public Text end;


	// Use this for initialization
	void Start () {
        StartCoroutine("LoseTime");

    }
	
	// Update is called once per frame
	void Update () {
        countDownText.text = ("Time Left = " + timeLeft);

        if (timeLeft <= 0)
        {
            Time.timeScale = .5f;
            string player1 = player1Score.text;
            string player2 = player2Score.text;
            int actual1Score = 0;
            int actual2Score = 0;
            for (int i = 10; i < player1.Length; i++)
            {
                if (char.IsDigit(player1[i]))
                {
                    actual1Score = Int32.Parse(player1[i].ToString());
                    break;
                }
            }
            for (int i = 10; i < player2.Length; i++)
            {
                if (char.IsDigit(player2[i]))
                {
                    actual2Score = Int32.Parse(player2[i].ToString());
                    break;
                }
            }
            if (actual1Score > actual2Score)
            {
                end.text = "Player 1 wins!";
            }
            else if (actual1Score < actual2Score)
            {
                end.text = "Player 2 wins!";
            }
            else if (actual1Score == actual2Score)
            {
                end.text = "Tie!";
            }
            end.gameObject.SetActive(true);
            countDownText.gameObject.SetActive(false);
            player1Score.gameObject.SetActive(false);
            player2Score.gameObject.SetActive(false);
        }

	}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
