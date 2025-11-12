using UnityEngine;
using UnityEngine.Events;

public class PuzzleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string correctAnswer = "abcd";
    

    void Update()
    {
        // Check every frame if needed (or you can call this manually after each drop)
        CheckAnswer();
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
            Debug.Log("✅ Puzzle Complete!");
            
        }
    }
}
