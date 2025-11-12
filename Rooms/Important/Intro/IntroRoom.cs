using Godot;
using System;
using GodotSimpleTools.Extensions;

public partial class IntroRoom : Node2D
{
    public override void _EnterTree()
    {
        GD.Print($"Hello World{MathExtension.RandomInt()}");
    }
}
