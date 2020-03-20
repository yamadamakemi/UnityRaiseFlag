using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    private object h_Score;

    // Start is called before the first frame update
    void Start()
    {
        // TODO スコアを動的に
        Debug.Log("game over");
        PlayerPrefs.SetInt("HighScore", 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
