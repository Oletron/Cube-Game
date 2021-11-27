using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{
    public GameObject player;
    public Material skin1;
    public Material skin2;
    public Material skin3;
    public Material skin4;
    public Material skin5;
    public int NumberSkin;
    // Start is called before the first frame update
    void Start()
    {
        NumberSkin = PlayerPrefs.GetInt("skinNum");
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
        if (NumberSkin == 3)
        {
            player.GetComponent<MeshRenderer>().material = skin3;
        }
        if (NumberSkin == 4)
        {
            player.GetComponent<MeshRenderer>().material = skin4;
        }
        if (NumberSkin == 5)
        {
            player.GetComponent<MeshRenderer>().material = skin5;
        }
    }
}
