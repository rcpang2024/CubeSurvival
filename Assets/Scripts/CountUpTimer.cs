using UnityEngine;
using UnityEngine.UI;

public class CountUpTimer : MonoBehaviour
{
    float startTime = 0f;
    float currentTime = 0f;
    [SerializeField] Text highScore;
    [SerializeField] Text theTime;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        currentTime = startTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime += 1 * Time.deltaTime;
        theTime.text = currentTime.ToString("0");
        if ((int) currentTime > PlayerPrefs.GetInt("HighScore", 0))
        {
            highScore.text = currentTime.ToString("0");
            PlayerPrefs.SetInt("HighScore", (int)currentTime); // sets the HighScore variable in PlayerPrefs to the current time
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore"); // HashMap
        // PlayerPrefs.DeleteKey("levelAt");
        highScore.text = "0";
    }
}
