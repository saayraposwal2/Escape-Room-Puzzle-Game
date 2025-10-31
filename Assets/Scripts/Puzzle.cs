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
        Debug.Log(isActive ? "UI closed" : "UI opened");
        Time.timeScale = isActive ? 1f : 0f;
    }
}
