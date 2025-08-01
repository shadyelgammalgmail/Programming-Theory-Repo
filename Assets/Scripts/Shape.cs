using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string _name;
    private Color _color;

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
        GetComponent<Renderer>().material.color = Color;
    }

    void OnMouseDown()
    {
        DisplayText();
    }

    public abstract void DisplayText();
}

