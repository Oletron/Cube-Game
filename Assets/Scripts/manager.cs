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
    public Text ScoreText;
    public GameObject failed;
    public GameObject complete;
    private GameObject Volume;
    public GameObject effect;
    public GameObject failedSound;
    public GameObject[] music;
    public GameObject pauseMenu;
    public GameObject confeti;
    private float score;
    private int rand;
    private int maxSpeed = 25;
    public int money;

    void Start()
    {
        Time.timeScale = 1;
        money = PlayerPrefs.GetInt("money");
        //это все музыка
        rand = UnityEngine.Random.Range(0, music.Length);
        music[rand].SetActive(true);
            //а вот это старт ускорения
            //StartCoroutine("speedIncrease");
        
    }
    void Update()
    { //основаная часть этого скрипта
            if (timer.NotPause)
            {
                score = (float)System.Math.Round(Time.timeSinceLevelLoad)-3;
                ScoreText.text = "Ваш счет: " + score.ToString();
            }
    }
    void OnTriggerEnter(Collider other)
    {
            if (other.tag == "money")
            {
             money++;
             PlayerPrefs.SetInt("money", money);
             Destroy(other.gameObject);
            }
            if (other.tag == "win")
            {
                StartCoroutine(win());
            }
    }
    void OnCollisionEnter(Collision other)
    {
        //проверка врезания во врага
        if (other.gameObject.tag == "enemy")
        {
            timer.NotPause = false;
            Instantiate(effect, transform.position, Quaternion.identity);
            music[rand].SetActive(false);
            failedSound.SetActive(true);
            PlayerPrefs.SetInt("money", money);
            Invoke("StopAll", 0.7f);
        }
    }
    private void StopAll()
    { //события при врезании
        pauseMenu.SetActive(false);
        PlayerPrefs.SetFloat("score", score);
        failed.SetActive(true);
        Time.timeScale  = 0;
    }
    private IEnumerator win()
    {
        confeti.SetActive(true);
        music[rand].SetActive(false);
        yield return new WaitForSeconds(1f);
        timer.NotPause = false;
        complete.SetActive(true);
        Time.timeScale = 0;
    }
}