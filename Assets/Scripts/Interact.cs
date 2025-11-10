using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    public int pillar;
    public bool isInRange = false;
    public UnityEvent interactAction;

    // Update is called once per frame
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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player left interaction range");
        }
    }
}
