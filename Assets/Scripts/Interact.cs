using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(SpriteRenderer))]
public class Interact : MonoBehaviour
{
    public int pillar;
    public bool isInRange = false;
    public UnityEvent interactAction;

    private Puzzle parentPuzzle;

    void Awake()
    {
        // Find Puzzle script on parent
        parentPuzzle = GetComponentInParent<Puzzle>();
    }

    void Update()
    {
        if (isInRange && Keyboard.current.eKey.wasPressedThisFrame)
        {
            JournalMechanics.inter(pillar);
            interactAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player in interaction range");

            // Tell parent puzzle to enable outline
            if (parentPuzzle != null)
            {
                parentPuzzle.SetOutline(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player left interaction range");

            // Tell parent puzzle to disable outline
            if (parentPuzzle != null)
            {
                parentPuzzle.SetOutline(false);
            }
        }
    }
}
