using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void backToHome()
    {
        SceneManager.LoadScene("Welcome");
    }
    public void resetSurvival()
    {
        PlayerPrefs.DeleteKey("HighScore"); // HashMap
        // highScore.text = "0";
    }
}
