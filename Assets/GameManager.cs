using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    public float delay = 0f;
    public int nextSceneLoad;
    public GameObject levelCompleteUI;
    [SerializeField] GameObject joystickUI;
    [SerializeField] GameObject pauseButtonUI;
    public void levelComplete()
    {
        joystickUI.SetActive(false);
        pauseButtonUI.SetActive(false);
        levelCompleteUI.SetActive(true);
        if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }
    public void gameOver()
    {
        if (isGameOver == false)
        {
            isGameOver = true; // flag set to true which prevents game ending from repeating
            Invoke("restart", delay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads the current scene
    }

    public void loadNextLevel()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneLoad);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
