using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }

    public void beginTutorial()
    {
        SceneManager.LoadScene("Sandbox");
    }

    public void beginLvls ()
    {
        SceneManager.LoadScene("Level1");
    }
}
