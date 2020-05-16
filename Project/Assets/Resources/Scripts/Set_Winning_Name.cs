using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Winning_Name : MonoBehaviour
{
    public GameObject winningNameText;

    void Start()
    {
        var UIwinningName = winningNameText.GetComponent<Text>();
        var name = PlayerPrefs.GetString("winningname");
        UIwinningName.text = name + " Wins";
    }
}
