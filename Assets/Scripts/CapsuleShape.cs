using UnityEngine;
public class CapsuleShape : Shape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Capsule!");
    }
}