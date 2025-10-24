using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    public float interactRadius = 2f;
    public LayerMask interactableLayer;
    private bool ePressedLastFrame = false;
    private Interactable highlightedObject;

    void Update()
    {
        bool ePressed = Keyboard.current.eKey.isPressed;
        if (ePressed && !ePressedLastFrame) // triggers once per key press
        {
            TryInteract();
        }
        ePressedLastFrame = ePressed;

        HighlightClosestInteractable();
    }

    void TryInteract()
    {
        // Find all colliders in a circle around the player
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, interactRadius, interactableLayer);

        if (hits.Length > 0)
        {
            // Optionally, interact with the first hit
            Interactable interactable = hits[0].GetComponentInParent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact();
                Debug.Log("Interacting with: " + hits[0].name);
            }
            else
            {
                Debug.Log("Hit something, but it's not interactable.");
            }
        }
        else
        {
            Debug.Log("No interactables in range");
        }
    }

    void HighlightClosestInteractable()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, interactRadius, interactableLayer);
        Interactable closest = null;
        float closestDist = float.MaxValue;

        foreach (var hit in hits)
        {
            float dist = Vector2.Distance(transform.position, hit.transform.position);
            if (dist < closestDist)
            {
                closestDist = dist;
                closest = hit.GetComponentInParent<Interactable>();
            }
        }

        // Remove highlight from previous object
        if (highlightedObject != null && highlightedObject != closest)
        {
            highlightedObject.SetOutline(false);
        }

        // Highlight the closest
        if (closest != null)
        {
            Debug.Log("Interactible in range...");
            closest.SetOutline(true);
        }

        highlightedObject = closest;
    }
}
