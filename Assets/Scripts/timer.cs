using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public Text timerStart;
    private int timeToStart;
    public manager script;
    public controller script2;
    // Start is called before the first frame update
    void Start()
    {
        timeToStart = 4;
        script.NotPause = false;
        script2.NotPause = false;
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
                script.NotPause = true;
                script2.NotPause = true;
                Destroy(timerStart);
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
