using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("level 1");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("start");
    }
    public void ChangeSkinMenu()
    {
        SceneManager.LoadScene("ChangeSkin");
    }
   public void ChangeMod()
    {
        SceneManager.LoadScene("ChangeS");
    }
}
