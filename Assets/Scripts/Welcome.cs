using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Welcome : MonoBehaviour
{
    [SerializeField] Text highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void startGame()
    {
        SceneManager.LoadScene("LevelSelect"); // old approach was to use getActiveScene.buildIndex + 1
    }
    public void startSurvivalMode()
    {
        SceneManager.LoadScene("Survival");
    }
    public void toSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
