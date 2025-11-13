using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PuzzleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string correctAnswer = "abcd";
    [SerializeField] public GameObject textDisplay;

    private bool flag = false;
    

    void Update()
    {
        // Check every frame if needed (or you can call this manually after each drop)
        CheckAnswer();
        if (flag && Keyboard.current.eKey.wasPressedThisFrame)
        {   
            flag = false;
            textDisplay.SetActive(false);
        }
    }

    public void CheckAnswer()
    {
        string currentAnswer = "";

        // Go through each child in order
        foreach (Transform child in transform)
        {
            Dragable tile = child.GetComponent<Dragable>();
            if (tile != null)
            {
                currentAnswer += tile.Tag;
            }
        }

        if (currentAnswer == correctAnswer)
        {
            flag = true;
            textDisplay.SetActive(true);
            NotebookContents.gameend();
        
            
        }
    }
}
