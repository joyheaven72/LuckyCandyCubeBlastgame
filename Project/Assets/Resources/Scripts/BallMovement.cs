using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedperHit;
    public float maxExtraSpeed;
    public GameObject racketPlayer2;
    public GameObject player2Name;
    public AudioSource startsound;
    private int _hitcount = 0;
    void Start()
    {
        startsound.Play();
        var UIplayer2Name = player2Name.GetComponent<Text>();
        
        if (PlayerPrefs.GetString("gamemode") == "1player")
        {
            racketPlayer2.GetComponent<RacketPlayer2_AI>().enabled = true;
            racketPlayer2.GetComponent<Racket_2_Movement>().enabled = false; 
            UIplayer2Name.text = "COM";
        }
        else if(PlayerPrefs.GetString("gamemode") == "2player")
        {
            racketPlayer2.GetComponent<RacketPlayer2_AI>().enabled = false;
            racketPlayer2.GetComponent<Racket_2_Movement>().enabled = true;
            UIplayer2Name.text = "Player 2";
        }
        
        StartCoroutine(this.StartBall());
    }

    private void PositionBall(bool isStartingPlayer1)
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if(isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-80, -66);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(200, -66);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall(isStartingPlayer1);
        
        this._hitcount = 0;
        yield return new WaitForSeconds(2);

        if(isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    
    public void IncreaseHitCount()
    {
        if(this._hitcount*this.extraSpeedperHit <= this.maxExtraSpeed)
        {
            _hitcount++;
        }
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = this.movementSpeed + this.extraSpeedperHit * this._hitcount;
        var rigidbody2D = this.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = direction * speed;
    }
}
