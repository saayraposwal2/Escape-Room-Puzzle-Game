using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    public bool inInRange = false;
    public UnityEvent interactAction;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (inInRange && Keyboard.current.eKey.wasPressedThisFrame)
        {
            interactAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inInRange = true;
            Debug.Log("Player in interaction range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inInRange = false;
            Debug.Log("Player left interaction range");
        }
    }
}
