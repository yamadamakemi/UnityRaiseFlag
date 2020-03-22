using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftButtonScript : MonoBehaviour
{
    public Text textFlag;

    // Start is called before the first frame update
    void Start()
    {

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
            // 別スクリプト参照
            GameObject g = GameObject.Find("MainScript");
            MainScript mainScript = g.GetComponent<MainScript>();
            mainScript.Reset();

            // 時間リセット
            mainScript.ResetTimer();

            // スコア加算
            mainScript.AddScore();
        }
        else
        {
            // 別スクリプト参照
            GameObject g = GameObject.Find("MainScript");
            MainScript mainScript = g.GetComponent<MainScript>();

            // ハイスコアを更新したら記録
            int h_score = PlayerPrefs.GetInt("HighScore");
            if (mainScript.score > h_score)
            {
                PlayerPrefs.SetInt("HighScore", mainScript.score);
            }

            // 不正解
            SceneManager.LoadScene("EndScene");
        }
    }
}
