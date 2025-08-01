using UnityEngine;

public class SphereShape : Shape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Sphere!");
    }
}
