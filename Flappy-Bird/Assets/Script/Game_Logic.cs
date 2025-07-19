using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Logic : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject GameOver;



    [ContextMenu ("Inc")]
    public void addScore( int scoreToAdd)
    {
        playerScore= playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        {
            GameOver.SetActive(true);

        }
    }
}
