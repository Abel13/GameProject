using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum Scenes
{
    Home,
    Game
}

public class game : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadSceneAsync(((int)Scenes.Game), LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
