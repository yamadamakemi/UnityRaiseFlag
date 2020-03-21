using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftButtonScript : MonoBehaviour
{
    public Text textFlag;
    public Text textScore;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボタンが押された時の処理
    public void OnClick()
    {
        //Debug.Log("Text: LeftClick");

        // 白:左  赤:右
        string text = textFlag.text;
        if (text == "白")
        {
            // 正解
            // TODO スコア加算
            score += 10;
            textScore.text = "スコア : " + score;

            // 別スクリプト参照
            GameObject g = GameObject.Find("MainScript");
            MainScript mainScript = g.GetComponent<MainScript>();
            mainScript.Reset();

            // 時間リセット
            mainScript.ResetTimer();
        }
        else
        {
            // 不正解
            SceneManager.LoadScene("EndScene");
        }
    }
}
