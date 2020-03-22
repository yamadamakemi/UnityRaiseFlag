using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public float limitTime;
    public Text textTimer;
    public Text textFlag;
    public Text textHighSoce;
    public Text textScore;
    public int score;
    private int h_Score;
    public bool isStop = false;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Reset();

        limitTime = 10.0f;

        score = 0;

        // ハイスコアを表示
        h_Score = PlayerPrefs.GetInt("HighScore");
        Debug.Log(h_Score);
        textHighSoce.text = "ハイスコア : " + h_Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // 経過時間を取得
        timer += Time.deltaTime;

        // 残り時間をtextTimerに表示
        float v = 10.0f;
        if (isStop == false)
        {
            v = Mathf.Round(limitTime - timer);
        }

        // 残り時間が0以下になったら、ゲームオーバー画面に遷移
        if (v <= 0.0f)
        {
            SceneManager.LoadScene("EndScene");
        }

        textTimer.text = "残り時間 : " + v + "秒";
    }

    // ゲームリセット
    public void Reset()
    {
        Debug.Log("Reset");

        // 赤か白をランダムに表示
        // TODO 赤と白を配列に入れて、ランダムで出す
        int v = Random.Range(0, 5);
        char v1 = (v < 3) ? '白' : '赤';
        textFlag.text = v1.ToString();
    }

    // 時間をリセット
    public void ResetTimer()
    {
        // 残り時間の初期値
        isStop = true;
        limitTime = 10.0f;
        timer = 0.0f;
        isStop = false;
    }

    public void AddScore() {
        // TODO スコア加算
        score += 10;
        textScore.text = "スコア : " + score;
    }
}
