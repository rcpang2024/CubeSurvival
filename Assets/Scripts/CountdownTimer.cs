using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 5f;
    public GameManager gameManager;
    float currentTime = 0f;
    [SerializeField] Text theTime;
    bool levelFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= 1 * Time.deltaTime;
        theTime.text = currentTime.ToString("0");

        if (currentTime <= 3.5)
        {
            theTime.color = Color.red;
        }
        if (currentTime <= 0)
        {
            currentTime = 0;
            if (levelFinished == false)
            {
                levelFinished = true;
                gameManager.levelComplete();
            }
        }
    }
}
