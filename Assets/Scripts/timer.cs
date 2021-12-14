using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public Text timerStart;
    private int timeToStart;
    public static bool NotPause=false;
    public bool timeStart;
    // Start is called before the first frame update
    void Start()
    {
        timeToStart = 4;
        NotPause = false;
        timeStart = true;
        StartCoroutine(GameStart());
    }
    private IEnumerator GameStart()
    {
        for (; ; )
        {
            timeToStart -= 1;
            timerStart.text = timeToStart.ToString();
            if (timeToStart <= 0)
            {
                NotPause = true;
                Destroy(timerStart);
                break;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
