using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject escape;
    void Start()
    {
        escape.SetActive(false);
    }

    public void TogglePanel()
    {
        bool isActive = escape.activeSelf;
        escape.SetActive(!isActive); // toggles on/off
        Time.timeScale = isActive ? 1f : 0f;
    }

    public void LoadNextLevel()
    {
        
    }
}
