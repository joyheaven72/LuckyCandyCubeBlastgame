using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Controller : MonoBehaviour
{
    private int _player1Score = 0;
    private int _player2Score = 0;
    public GameObject player1ScoreText;
    public GameObject player2ScoreText;
    public GameObject player2Name;

    public int winScore;
    void Update()
    {
        if(_player1Score>=winScore)
        {
            PlayerPrefs.SetString("winningname", "Player 1");
            SceneManager.LoadScene("GameOver");
        }
        if(_player2Score>=winScore)
        {
            var UIplayer2Name = player2Name.GetComponent<Text>();
            PlayerPrefs.SetString("winningname", UIplayer2Name.text);
            SceneManager.LoadScene("GameOver");
        }
    }
    private void FixedUpdate()
    {
        var UIplayer1Score = player1ScoreText.GetComponent<Text>();
        var UIplayer2Score = player2ScoreText.GetComponent<Text>();

        UIplayer1Score.text = _player1Score.ToString();
        UIplayer2Score.text = _player2Score.ToString();
    }

    public void player1scores()
    {
        this._player1Score++;
    }

    public void player2scores()
    {
        this._player2Score++;
    }
}
