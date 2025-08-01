using UnityEngine;

// Inherits from Shape (OOP: Inheritance)
public class CubeShape : Shape
{
    public override void DisplayText()
    {
        // Polymorphism: Unique message for Cube
        UIManager.Instance.ShowMessage("I am a Cube!");
    }
}