using UnityEngine;

// OOP: Abstraction (defines high-level DisplayText function for all shapes)
// OOP: Inheritance (base class for all shape types)
// OOP: Encapsulation (private fields with controlled public access)
public abstract class Shape : MonoBehaviour
{
    private string _name;
    private Color _color=Color.white;//set default to white

    //  Encapsulation via property with validation
    public string Name
    {
        get => _name;
        set => _name = value.Length > 10 ? "Default" : value;
    }

    public Color Color
    {
        get => _color;
        set => _color = value;
    }

    void Start()
    {
        // Set the color of the shape when scene starts
        GetComponent<Renderer>().material.color = Color;
    }

    void OnMouseDown()
    {
        // Called when the shape is clicked
        DisplayText(); // Abstraction + Polymorphism
    }

    // Polymorphism: Each shape overrides this to show its own message
    public abstract void DisplayText();
}
