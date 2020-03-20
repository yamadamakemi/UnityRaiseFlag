using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    private float limitTime;
    public Text textTimer;
    public Text textFlag;
    public Text textHighSoce;
    private int h_Score;

    // Start is called before the first frame update
    void Start()
    {
        Reset();

        // ハイスコアを表示
        h_Score = PlayerPrefs.GetInt("HighScore");
        Debug.Log(h_Score);
        textHighSoce.text = "ハイスコア : " + h_Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // 残り時間をtextTimerに表示
        float v = Mathf.Round(limitTime - Time.time);

        // 残り時間が0以下になったら、ゲームオーバー画面に遷移
        if (v <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }

        textTimer.text = "残り時間 : " + v + "秒";

    }

    // ゲームリセット
    public void Reset()
    {
        Debug.Log("Reset");

        // 残り時間の初期値
        limitTime = 10;

        // 赤か白をランダムに表示
        // TODO 赤と白を配列に入れて、ランダムで出す
        int v = Random.Range(0, 5);
        char v1 = (v < 3) ? '白' : '赤';
        textFlag.text = v1.ToString();
    }
}
