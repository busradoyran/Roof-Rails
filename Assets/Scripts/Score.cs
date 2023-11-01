using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public bool gameOver;
    public int score = 0;

    public void Update()
    {
        if (gameOver)
        {
            score = PlayerPrefs.GetInt("Score", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Score", score);
        }
        scoreText.text = score.ToString("0");
    }
}
