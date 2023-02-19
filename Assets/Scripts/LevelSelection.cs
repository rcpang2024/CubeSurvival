using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons; // array because level progression is linear
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i <levelButtons.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButtons[i].interactable = false;
                levelButtons[i].GetComponent<Image>().color = Color.red;
            } else
            {
                levelButtons[i].GetComponent<Image>().color = Color.green;
            }
        }
    }

    public void goToLevel(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
