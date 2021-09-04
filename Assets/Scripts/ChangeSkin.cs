using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSkin : MonoBehaviour
{
    public GameObject tick1;
    public GameObject tick2;
    public Button skin2;
    private float highScore;
    public int NumberSkin;
    // Start is called before the first frame update
    void Start()
    {
        
        NumberSkin = PlayerPrefs.GetInt("skin");
        highScore = PlayerPrefs.GetFloat("highscore");
        skin2.interactable = false;
        print(skin2.interactable);
        if (highScore >= 100)
        {
            skin2.interactable = true;
            print(skin2.interactable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberSkin == 1)
        {
            tick1.SetActive(true);
            tick2.SetActive(false);
        }
        if (NumberSkin == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
        }
    }
    public void Car1()
    {
        NumberSkin = 1;
        PlayerPrefs.SetInt("skin", NumberSkin);
    }
    public void Car2()
    {
        NumberSkin = 2;
        PlayerPrefs.SetInt("skin", NumberSkin);
    }

}
