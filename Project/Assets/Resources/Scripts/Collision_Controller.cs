using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Controller : MonoBehaviour
{
    public BallMovement ballMovement;
    public Score_Controller scoreController;

    private void BounceFromRacket(Collision2D collision)
    {
        var ballPosition = this.transform.position;
        var racketPosition = collision.collider.transform.position;
        var racketHeight = collision.collider.bounds.size.y;

        float x;
        if(collision.collider.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCount();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "RacketPlayer1" || collision.collider.name == "RacketPlayer2")
        {
            BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            scoreController.player2scores();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if(collision.gameObject.name == "WallRight")
        {
            scoreController.player1scores();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}
