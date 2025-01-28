// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

///     Your game code goes inside this class!
public class Game
{
    ///     Setup runs once before the game loop begins.
    public void Setup()
    {
        Window.SetTitle("2D Interactive Drawing"); //Name of window
        Window.SetSize(400, 400); //Set window size
    }

    public void Update()
    {
        Window.ClearBackground(Color.Green); //Grass background

        Draw.FillColor = Color.Gray; //The road
        Draw.Rectangle(0, 160, 400, 100);
        
        Draw.FillColor = Color.Blue; //The blue car, user can move it up and down
        Draw.Rectangle(200, Input.GetMouseY(), 100, 50);
        Draw.LineColor = Color.Blue;
        Draw.Rectangle(220, Input.GetMouseY(), 60, 80);

        Draw.FillColor = Color.Black; //Blue car wheels
        Draw.Circle(220, Input.GetMouseY(), 15);
        Draw.FillColor = Color.Black;
        Draw.Circle(280, Input.GetMouseY(), 15);
    }
}
