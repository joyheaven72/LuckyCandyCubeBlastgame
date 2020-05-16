using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_1_button : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.SetString("gamemode", "1player");
        SceneManager.LoadScene("Game");
    }
}
