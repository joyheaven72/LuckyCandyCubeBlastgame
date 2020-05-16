using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Controller : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    public AudioSource missSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            racketSound.Play();
        }
        else if(collision.gameObject.name == "WallLeft" || collision.gameObject.name == "WallRight")
        {
            missSound.Play();
        }
        else
        {
            wallSound.Play();
        }
    }
}
