using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject SetVolume;
    public void RestartLevel1()
    {
        SceneManager.LoadScene("level 1");
    }
    public void ChooseMod()
    {
        SceneManager.LoadScene("ChooseMod");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("start");
    }
    public void ChangeSkinMenu()
    {
        SceneManager.LoadScene("ChangeSkin");
    }
   public void Lobby()
    {
        SceneManager.LoadScene("loading");
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

