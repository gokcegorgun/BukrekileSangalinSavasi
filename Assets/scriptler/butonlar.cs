using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;


public class butonlar : MonoBehaviour
{

    public void baslabuton()
    {
        SceneManager.LoadScene("level1");
    }
    public void cıkısbuton()
    {
        Application.Quit();
    }
    public void ayarlarbutonbasıldıgında()
    {
       
    }
}
