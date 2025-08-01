using UnityEngine;
// Inherits from Shape (OOP: Inheritance)
public class CapsuleShape : Shape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Capsule!");
    }
}