using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_2_Button : MonoBehaviour
{
   public void PlayGame()
    {
        PlayerPrefs.SetString("gamemode", "2player");
        SceneManager.LoadScene("Game");
    }
}
