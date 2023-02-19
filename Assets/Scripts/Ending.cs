using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("YOU HAVE QUIT THE GAME");
        Application.Quit();
    }

    public void backToHome()
    {
        SceneManager.LoadScene("Welcome");
    }
}
