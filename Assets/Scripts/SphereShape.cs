using UnityEngine;
// Inherits from Shape (OOP: Inheritance)
public class SphereShape : Shape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Sphere!");
    }
}
