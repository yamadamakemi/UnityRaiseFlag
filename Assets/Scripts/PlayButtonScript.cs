using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
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
        //Debug.Log("Text: test");
        // シーンの切り替え
        SceneManager.LoadScene("GameScene");
    }
}
