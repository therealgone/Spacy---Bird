using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void gamestart()
    {
         SceneManager.LoadScene(1);
    }
}
