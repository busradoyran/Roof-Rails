using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    //public GameObject gameOverUI;
    public float restartDelay = 1f;

    //public void CompleteLevel()
    //{
    //    completeLevelUI.SetActive(true);
    //}

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //gameOverUI.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Play Again Button
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
