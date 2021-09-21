using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class controller : MonoBehaviour
{
    private UnityEngine.Object explosion;
    private bool checkColl = true;
    public float force;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
      
        //if (Input.acceleration.x >0 )
        if (Input.GetKeyDown(KeyCode.RightArrow)&checkColl)
            rb.velocity = new Vector3(10, 0, 0);
        //if (Input.acceleration.x<0)
        if (Input.GetKeyDown(KeyCode.LeftArrow) & checkColl)
            rb.velocity = new Vector3(-10, 0, 0);

        //if (Input.touchCount > 0)
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump();
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        checkColl = true;
    }
    void jump()
    {
        if (checkColl)
        {
            rb.velocity = new Vector3(rb.velocity.x, force);
            checkColl = false;

        }
    }
}
