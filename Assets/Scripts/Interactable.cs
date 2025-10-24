using UnityEngine;
public class Interactable : MonoBehaviour
{
    public Sprite symbolSprite;
    private SpriteRenderer spriteRenderer;
    private Material originalMaterial;
    public Material outlineMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
            originalMaterial = spriteRenderer.material;
    }
    public void Interact()
    {
        Debug.Log(gameObject.name + " was interacted with!");

        if (!SymbolUI.Instance.isVisible)
        {
            SymbolUI.Instance.ShowSymbol(symbolSprite);
        }
        else
        {
            SymbolUI.Instance.HideSymbol();
        }

    }
    public void SetOutline(bool enable)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.material = enable ? outlineMaterial : originalMaterial;
        }
    }
}
