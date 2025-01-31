// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

///     Your game code goes inside this class!
public class Game
{

    int puddleCount = 5;
    int[] puddlePositionsX;
    int[] puddlePositionsY;

    int rainCount = 40;
    int[] rainPositionsX;
    int[] rainPositionsY;
    ///     Setup runs once before the game loop begins.
 
    public void Setup()
    {
    
       

        Window.SetTitle("2D Interactive Drawing"); //Name of window
        Window.SetSize(400, 400); //Set window size

        puddlePositionsX = new int[puddleCount];
        puddlePositionsY = new int[puddleCount];
        for (int i = 0; i < puddleCount; i++)
        {
            puddlePositionsX[i] = Random.Integer(0, 400);
            puddlePositionsY[i] = Random.Integer(0, 400);
        }

        rainPositionsX = new int[rainCount];
        rainPositionsY = new int[rainCount];
        
    }
   void DrawRedCar(float x, float y)
        {
        
            Draw.FillColor = Color.Black;
            Draw.Triangle(Input.GetMouseX() + 90, 200, Input.GetMouseX() + 80, 200, Input.GetMouseX() + 85, 180);

            Draw.FillColor = Color.Red; //The Red car, user can move it up and down
            Draw.Rectangle(Input.GetMouseX(), 250 - 50, 100, 30);
            Draw.LineColor = Color.Red;

            Draw.FillColor = Color.Black; //Red car wheels
            Draw.Circle(Input.GetMouseX(), 230, 15);
            Draw.FillColor = Color.Black;
            Draw.Circle(Input.GetMouseX() + 100, 230, 15);
        }
    public void Update()
    {
        Window.ClearBackground(Color.Green); //Grass background

        Draw.FillColor = Color.Gray; //The road
        Draw.Rectangle(0, 160, 400, 100);

        for (int i = 0; i < rainCount; i++)
        {
            rainPositionsX[i] = Random.Integer(0, 400);
            rainPositionsY[i] = Random.Integer(0, 400);
        }

        DrawRedCar(100, 100);

        //Puddles
        Draw.FillColor = Color.Cyan;
        for (int i = 0; i < puddleCount; i++)
        {
            Draw.Circle(puddlePositionsX[i], puddlePositionsY[i], 20);
        }

        //Rain drops
        Draw.FillColor = Color.Cyan;
        for (int i = 0; i < rainCount; i++)
        {
            Draw.Capsule(rainPositionsX[i], rainPositionsY[i], rainPositionsX[i], rainPositionsY[i] +5, 5 );
        }
        
        Draw.FillColor = Color.Blue; //The blue car, user can move it up and down
        Draw.Rectangle(200, Input.GetMouseY() - 50, 100, 50);
        Draw.LineColor = Color.Blue;
        Draw.Rectangle(220, Input.GetMouseY() - 80, 60, 80);

        Draw.FillColor = Color.Black; //Blue car wheels
        Draw.Circle(220, Input.GetMouseY(), 15);
        Draw.FillColor = Color.Black;
        Draw.Circle(280, Input.GetMouseY(), 15);
    }
    
}
