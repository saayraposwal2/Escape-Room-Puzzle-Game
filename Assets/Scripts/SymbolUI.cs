using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SymbolUI : MonoBehaviour
{
    public static SymbolUI Instance;
    public Image symbolImage;
    public Image backgroundImage;

    public bool isVisible = false;

    void Awake()
    {
        Instance = this;
        HideSymbol();
    }

    void Update()
    {
        
    }

    public void ShowSymbol(Sprite newSymbol)
    {
        symbolImage.sprite = newSymbol;
        symbolImage.color = new Color(1, 1, 1, 1); // make visible
        backgroundImage.color = new Color(0.149f, 0.149f, 0.149f, 1f);
        isVisible = true;
    }

    public void HideSymbol()
    {
        symbolImage.color = new Color(1, 1, 1, 0); // make invisible
        backgroundImage.color = new Color(1, 1, 1, 0);
        isVisible = false;
    }
}
