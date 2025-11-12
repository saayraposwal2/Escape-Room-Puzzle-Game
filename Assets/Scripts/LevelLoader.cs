using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float delayBeforeNextScene = 2f;
    [SerializeField] private string nextSceneName = "Level 2";

    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    private IEnumerator LoadSceneCoroutine()
    {
        Debug.Log("Loading " + nextSceneName + " ...");
        yield return new WaitForSecondsRealtime(delayBeforeNextScene);

        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
