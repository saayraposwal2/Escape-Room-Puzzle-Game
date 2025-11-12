using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Puzzle : MonoBehaviour
{
    public GameObject escape;
    public Material outlineMaterial;
    private Material originalMaterial;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
            originalMaterial = spriteRenderer.material;

        if (escape != null)
            escape.SetActive(false);
    }

    public void TogglePanel()
    {
        bool isActive = escape.activeSelf;
        escape.SetActive(!isActive);
        Debug.Log(isActive ? "UI closed" : "UI opened");
        Time.timeScale = isActive ? 1f : 0f;
    }

    public void SetOutline(bool enable)
    {
        if (spriteRenderer == null) return;

        if (enable && outlineMaterial != null)
        {
            spriteRenderer.material = outlineMaterial;
            Debug.Log("Outline enabled on parent Puzzle object.");
        }
        else if (originalMaterial != null)
        {
            spriteRenderer.material = originalMaterial;
            Debug.Log("Outline disabled on parent Puzzle object.");
        }
    }
}
