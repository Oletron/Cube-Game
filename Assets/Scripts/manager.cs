using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Security.Cryptography;
using System;

public class manager : MonoBehaviour
{
    public GameObject obj;
    public Text text;
    public GameObject failed;
    public GameObject Volume;
    public GameObject effect;
    public GameObject failedSound;
    public GameObject[] music;
    public bool NotPause;
    public GameObject PauseButton;
    public pauseManager PauseScript;
    public GameObject pauseMenu;
    public controller script2;
    private float speed1 = 12f;
    private float score;
    private int rand;
    private AudioSource audioSrc;
    void Start()
    {
        //это все музыка
        rand = UnityEngine.Random.Range(0, music.Length);
        music[rand].SetActive(true);
        Volume = music[rand];
        audioSrc = Volume.GetComponent<AudioSource>();
        audioSrc.volume = PlayerPrefs.GetFloat("volume");
    }
    void Update()
    { //основаная часть этого скрипта
        if (NotPause)
        {
            going();
            score = (float)System.Math.Round(Time.timeSinceLevelLoad);
            text.text = "Ваш счет: " + score.ToString();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //проверка врезания во врага
        if (other.gameObject.tag == "enemy")
        {
            StartCoroutine(CoroutinePause());
        }
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        pause();
        PlayerPrefs.SetFloat("score", score);
        complete.SetActive(true);
    }
    */
    void going()
    {
        //собственно передвижение
        obj.transform.Translate(Vector3.forward * speed1 * Time.deltaTime);
    }
    private IEnumerator CoroutinePause()
    { //события при врезании
        Instantiate(effect, transform.position, Quaternion.identity);
        speed1 = 0;
        music[rand].SetActive(false);
        failedSound.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        NotPause = false;
        script2.NotPause = false;
        pauseMenu.SetActive(false);
        PlayerPrefs.SetFloat("score", score);
        failed.SetActive(true);
    }
}