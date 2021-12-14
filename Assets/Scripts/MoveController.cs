using UnityEngine;

public class MoveController : MonoBehaviour
{
    private bool checkColl;
    public float force;
    int speed = 15;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (timer.NotPause)
        {
            Vector3 acceleration = Input.acceleration;
            rb.velocity = new Vector3(acceleration.x * speed, rb.velocity.y, speed);
            if (Input.touchCount > 0)
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
            /*
            if (Input.GetKeyDown(KeyCode.UpArrow)&checkColl)
            {
                rb.AddForce(Vector3.up*force, ForceMode.Impulse);
            }
            float moveHorizontal = Input.GetAxis("Horizontal");
            rb.velocity = new Vector3(moveHorizontal*speed, rb.velocity.y, speed);
            */
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        checkColl = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        checkColl = false;
    }
    /*
private IEnumerator speedIncrease()
{
    //корутина отвечающая за ускорение
    yield return new WaitForSeconds(10);
    if (speed1 <= maxSpeed)
    {
        speed1 ++;
        StartCoroutine("speedIncrease");
    }
}
*/
}