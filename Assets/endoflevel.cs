using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endoflevel : MonoBehaviour
{
 

    public void endofgame ()
    {
       // Debug.Log("HIT");
       //Application.Quit();
       SceneManager.LoadScene("fps");
    }
}
