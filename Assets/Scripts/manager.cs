using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Security.Cryptography;
using System;
using Photon.Pun;
public class manager : MonoBehaviour
{
    public GameObject obj;
    public Text ScoreText;
    public GameObject failed;
    private GameObject Volume;
    public GameObject effect;
    public GameObject failedSound;
    public GameObject[] music;
    public bool NotPause;
    public GameObject pauseMenu;
    public controller script2;
    public float speed1 = 12f;
    private float score;
    private int rand;
    private int maxSpeed = 25;
    private int money;
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
        Time.timeScale = 1;
        //��� ��� ������
        if (NotPause)
        {
            rand = UnityEngine.Random.Range(0, music.Length);
            music[rand].SetActive(true);
            //� ��� ��� ����� ���������
            StartCoroutine("speedIncrease");
            money = PlayerPrefs.GetInt("money");
        }
    }
    void Update()
    { //��������� ����� ����� �������
        if (view.IsMine)
        {
            if (NotPause)
            {
                going();
                score = (float)System.Math.Round(Time.timeSinceLevelLoad);
                ScoreText.text = "��� ����: " + score.ToString();
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (view.IsMine)
        {
            //�������� �������� �� �����
            if (other.gameObject.tag == "enemy")
            {
                StartCoroutine(CoroutinePause());
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (view.IsMine)
        {
            if (other.tag == "money")
            {
            money++;
            Destroy(other.gameObject);
            }
        }
    }
    void going()
    {
        //���������� ������������
        obj.transform.Translate(Vector3.forward * speed1 * Time.deltaTime);
    }
    private IEnumerator CoroutinePause()
    { //������� ��� ��������
        Instantiate(effect, transform.position, Quaternion.identity);
        speed1 = 0;
        music[rand].SetActive(false);
        failedSound.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        NotPause = false;
        script2.NotPause = false;
        pauseMenu.SetActive(false);
        PlayerPrefs.SetFloat("score", score);
        PlayerPrefs.SetInt("money", money);
        failed.SetActive(true);
        Time.timeScale  = 0;
    }
    /*
    private IEnumerator speedIncrease()
    {
        //�������� ���������� �� ���������
        yield return new WaitForSeconds(10);
        if (speed1 <= maxSpeed)
        {
            speed1 ++;
            StartCoroutine("speedIncrease");
        }
    }
    */
}