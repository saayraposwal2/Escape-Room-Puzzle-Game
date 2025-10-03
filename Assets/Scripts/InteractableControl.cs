using UnityEngine;
using UnityEngine.InputSystem;

public class InteractableControl : MonoBehaviour
{
     [Header("UI Panel")]
    public GameObject uiPanel; // Drag your UI panel here

    private bool isPlayerNearby = false;
    private PlayerController playerInput;
    private PlayerController openAction;

    private void Awake()
    {
        // Reference your action
        openAction = new PlayerController();
    }

    private void OnEnable()
    {
        openAction.Interactables.Enable();
        openAction.Interactables.Open.performed += OnOpenPerformed;
    }

    private void OnDisable()
    {
        openAction.Interactables.Open.performed -= OnOpenPerformed;
        openAction.Interactables.Disable();
    }

    private void OnOpenPerformed(InputAction.CallbackContext ctx)
    {
        if (isPlayerNearby)
        {
            uiPanel.SetActive(!uiPanel.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Debug.Log("Player entered interaction zone.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            if (uiPanel.activeSelf) uiPanel.SetActive(false);
            Debug.Log("Player left interaction zone.");
        }
    }
}
