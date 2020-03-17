using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    private float limitTime;
    public Text textTimer;
    public Text textFlag;

    // Start is called before the first frame update
    void Start()
    {
        // 残り時間の初期値
        limitTime = 10;

        // 赤か白をランダムに表示
        // TODO 赤と白を配列に入れて、ランダムで出す
        int v = Random.Range(0, 5);
        char v1 = (v < 3) ? '白' : '赤';
        textFlag.text = v1.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // 残り時間をtextTimerに表示
        float v = Mathf.Round(limitTime - Time.time);
        textTimer.text = "残り時間 : " + v + "秒";
    }
}
