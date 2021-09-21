using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject SetVolume;
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
    public void ExitVolume()
    {
        SetVolume.SetActive(false);
    }
    public void Volume()
    {
        SetVolume.SetActive(true);
    }
}
