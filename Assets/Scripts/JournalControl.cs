using UnityEngine;
using UnityEngine.InputSystem;
public class JournalControl : MonoBehaviour
{
    public GameObject journalUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        journalUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.jKey.wasPressedThisFrame)
        {
            journalUI.SetActive(!journalUI.activeSelf);
            Time.timeScale = journalUI.activeSelf ? 0f : 1f;
        }
    }
}
