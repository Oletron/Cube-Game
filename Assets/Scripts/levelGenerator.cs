using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    public int numberlevel;
    public GameObject[] Prefabs;
    public GameObject FirstL;
    public Transform Points;
    private int score1;
    private int score2;
    private GameObject pref;

    void Start()
    {
        //Destroy(FirstL, 13);
    }
    void OnTriggerEnter(Collider col)
    {
        numberlevel = UnityEngine.Random.Range(0,Prefabs.Length);
        pref=Instantiate(Prefabs[numberlevel], new Vector3(0,0,Points.position.z), Quaternion.identity);
        Destroy(pref,12);
    }
}