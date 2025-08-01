using UnityEngine;

// Central manager for UI updates (supports abstraction)
public class UIManager : MonoBehaviour
{
    public static UIManager Instance; // Singleton instance

    public TextMesh shapesText; // Reference to TextMesh object in the scene

    void Awake()
    {
        // Simple Singleton pattern
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Abstraction: A high-level method to update UI
    public void ShowMessage(string message)
    {
        if (shapesText != null)
        {
            shapesText.text = message;
        }else{
            Debug.LogWarning("ShapesText is not assigned in UIManager!");
        }
    }
}