using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    private float limitTime;
    public Text textTimer;

    // Start is called before the first frame update
    void Start()
    {
        // 残り時間の初期値
        limitTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // 残り時間をtextTimerに表示
        float v = Mathf.Round(limitTime - Time.time);
        textTimer.text = "残り時間 : " + v + "秒";
    }
}
