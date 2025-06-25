using Godot;

namespace Rune.Object;

public partial class Object : RigidBody3D
{
    [Export] private string name;
    [Export] private string description;

    [Export] private Sprite2D icon;

    public override void _Ready()
    {

    }

    public override void _Process(double delta)
    {

    }

}
