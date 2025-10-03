using UnityEngine;
using UnityEngine.InputSystem;

public class JournallControl : MonoBehaviour
{
    public GameObject journalPanel;
    private bool isOpen = false;
    private PlayerController inputActions;

    private void Awake()
    {
        inputActions = new PlayerController();
    }

    private void OnEnable()
    {
        inputActions.journal.Enable();
        inputActions.journal.openjournal.performed += OnJournalToggle;
    }

    private void OnDisable()
    {
        inputActions.journal.openjournal.performed -= OnJournalToggle;
        inputActions.journal.Disable();
    }

    private void OnJournalToggle(InputAction.CallbackContext context)
    {
        isOpen = !isOpen;
        journalPanel.SetActive(isOpen);
        Time.timeScale = isOpen ? 0f : 1f;
    }
}
