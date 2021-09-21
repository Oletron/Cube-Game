using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Security.Cryptography;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;
    public Text text;
    public GameObject failed;
    public GameObject Volume;
    public GameObject complete;
    public GameObject effect;
    public GameObject failedSound;
    public GameObject[] music;
    public float speed1 = 12f;
    private float score;
    public int rand;
    private AudioSource audioSrc;
    private bool game_is_paused = false;
    void Start()
    {
        rand = UnityEngine.Random.Range(0, music.Length);
        music[rand].SetActive(true);
        Volume = music[rand];
        audioSrc = Volume.GetComponent<AudioSource>();
        audioSrc.volume = PlayerPrefs.GetFloat("volume");
        resume();
    }
    void Update()
    {
            going();
            score = (float)System.Math.Round(Time.timeSinceLevelLoad);
            text.text = "¬аш счет: "+score.ToString();
    }
    void OnCollisionEnter(Collision other)
    {
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
        obj.transform.Translate(Vector3.forward * speed1 * Time.deltaTime);
    }
    void pause()
    {
        Time.timeScale = 0f;
        game_is_paused = true;
    }
    void resume()
    {
        Time.timeScale = 1f;
        game_is_paused = false;
    }
    public void check()
    {
        if (game_is_paused)
        {
            resume();
        }
        else
        {
            pause();
        }
    }
    private IEnumerator CoroutinePause()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        speed1 = 0;
        music[rand].SetActive(false);
        failedSound.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        pause();
        PlayerPrefs.SetFloat("score", score);
        failed.SetActive(true);
    }
}