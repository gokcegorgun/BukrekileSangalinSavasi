using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class gameoversahnebuton : MonoBehaviour
{
    public void tekraroyna()
    {
        SceneManager.LoadScene("level1");
    }
    public void cıkısbuton()
    {
        Debug.Log("cıktın");
        Application.Quit();
    }
}
