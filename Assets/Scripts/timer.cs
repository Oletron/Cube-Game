using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public Text timerStart;
    private int timeToStart;
    public manager script1;
    public controller script2;
    public bool timeStart;
    // Start is called before the first frame update
    void Start()
    {
        timeToStart = 5;
        script1.NotPause = false;
        script2.NotPause = false;
        timeStart = true;
    }
    void Update()
    {
        if (timeStart)
        {
            StartCoroutine(GameStart());
            return;
            
        }
    }
    private IEnumerator GameStart()
    {
        for (; ; )
        {
            timeToStart -= 1;
            timerStart.text = timeToStart.ToString();
            if (timeToStart <= 0)
            {
                script1.NotPause = true;
                script2.NotPause = true;
                Destroy(timerStart);
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
