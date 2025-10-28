using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; // <-- new Input System namespace

public class ResetLevel : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}