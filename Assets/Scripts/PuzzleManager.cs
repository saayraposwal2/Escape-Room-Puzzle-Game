using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctAnswer = "abcd";
    [SerializeField] private GameObject completeMessageUI;
    [SerializeField] private LevelLoader LevelLoader; // Direct reference

    private bool puzzleCompleted = false;

    void Update()
    {
        CheckAnswer();
    }

    public void CheckAnswer()
    {
        if (puzzleCompleted) return;

        string currentAnswer = "";

        foreach (Transform child in transform)
        {
            Dragable tile = child.GetComponent<Dragable>();
            if (tile != null)
                currentAnswer += tile.Tag;
        }

        if (currentAnswer == correctAnswer)
        {
            puzzleCompleted = true;
            Debug.Log("✅ Puzzle Complete!");

            if (completeMessageUI != null)
            {
                completeMessageUI.SetActive(true);
            }
                
            // Directly call the loader script
            if (LevelLoader != null)
            {
                //Debug.Log("Calling LevelLoader...");
                LevelLoader.LoadNextLevel();
            }
                
        }
    }
}
