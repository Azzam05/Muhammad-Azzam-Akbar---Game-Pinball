using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUi : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball");
    }

    private void ExitButton()
    {
        Application.Quit();
    }
}
