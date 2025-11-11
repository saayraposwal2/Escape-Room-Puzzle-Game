using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void playgame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
