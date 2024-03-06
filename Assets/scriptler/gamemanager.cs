using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;



public class gamemanager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    void Start()
    {
        score = 0;
        scoretext.text = scoretext.ToString();
    }


    public void Updatescore()
    {
        score++;
        scoretext.text = score.ToString();
    }

}
