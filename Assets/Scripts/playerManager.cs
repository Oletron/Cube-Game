using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{
    public GameObject player;
    public Material skin1;
    public Material skin2;

    public int NumberSkin;
    public int NumberMode;
    // Start is called before the first frame update
    void Start()
    {
        NumberSkin = PlayerPrefs.GetInt("skin");
        //NumberMode = PlayerPrefs.GetInt("mode");
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberSkin ==1)
        {
            player.GetComponent<MeshRenderer>().material = skin1;
        }
        if (NumberSkin ==2)
        {
            player.GetComponent<MeshRenderer>().material = skin2;
        }
        /*
        if (NumberMode == 1)
        {
            SceneManager.LoadScene("nightMode");
        }
        
        if (NumberMode == 2)
        {
            SceneManager.LoadScene("level1");
        }
        */
    }
}
