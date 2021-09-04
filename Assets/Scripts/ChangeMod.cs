using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMod : MonoBehaviour
{
    public GameObject tick1;
    public GameObject tick2;
    public int NumberMode;
    // Start is called before the first frame update
    void Start()
    {
        NumberMode = PlayerPrefs.GetInt("mode");
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberMode == 1)
        {
            tick1.SetActive(true);
            tick2.SetActive(false);
        }
        if (NumberMode == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
        }
    }
    public void mode1()
    {
        NumberMode = 1;
        PlayerPrefs.SetInt("mode", NumberMode);
    }
    public void mode2()
    {
        NumberMode = 2;
        PlayerPrefs.SetInt("mode", NumberMode);
    }
}

