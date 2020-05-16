using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2_AI : MonoBehaviour
{
    public float movementSpeed;
    public GameObject ball;

    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - ball.transform.position.y)>30)
        {
            if(this.transform.position.y>ball.transform.position.y)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
            }
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
        }
    }
}
