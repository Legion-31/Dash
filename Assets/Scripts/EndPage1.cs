using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndPage1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            
            Application.Quit();
        }
    }
    
}

