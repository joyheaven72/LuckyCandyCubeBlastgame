using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Button : MonoBehaviour
{
   public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
