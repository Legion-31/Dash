using UnityEngine.SceneManagement;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnded = false;
    public float restartDelay = 3.5f;
    public void EndGame()
    {

        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GO");
            Invoke("Endpage", restartDelay);
        }

    }

    /// void Restart()
    //{
    // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    /// }
    void Endpage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
