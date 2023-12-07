using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelUnlock;
    public Button[] buttons;


    void Start()
    {
     //PlayerPrefs.DeleteAll();
        levelUnlock = PlayerPrefs.GetInt("levels",2);


        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnlock; i++)
        {
            if (i < buttons.Length)
            {
                buttons[i].interactable = true;
            }   
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void QuitGame()
    {
        Application.Quit();  
    }
}
