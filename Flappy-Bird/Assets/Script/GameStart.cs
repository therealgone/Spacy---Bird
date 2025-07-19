using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        quit();
    }



    public void gamestart()
    {
         SceneManager.LoadScene(1);
    }

    public void quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
    }
}
