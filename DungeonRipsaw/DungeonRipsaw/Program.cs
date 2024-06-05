using Raylib_cs;
using System.Numerics;

public class Program
{
    static string title = "Game Title"; // Window title
    static int screenWidth = 1200; // Screen width
    static int screenHeight = 1000; // Screen height
    static int targetFps = 120; // Target frames-per-second

    // Variables for the square
    static Vector2 squarePosition;
    static int squareSize = 50;
    static float squareSpeed = 5.0f;

    static void Main()
    {
        // Create a window to draw to. The arguments define width and height
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // Set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {
            // Enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // Clear the canvas with one color
            Raylib.ClearBackground(Raylib_cs.Color.Black);
            // Your game code here. This is a function YOU define.
            Update();
            // Stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }
        // Close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // Initialize the square position to the center of the screen
        squarePosition = new Vector2(screenWidth / 2, screenHeight / 2);
    }

    static void Update()
    {
        // Move the square based on user input
        if (Raylib.IsKeyDown(KeyboardKey.W)) squarePosition.Y -= squareSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.S)) squarePosition.Y += squareSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.A)) squarePosition.X -= squareSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.D)) squarePosition.X += squareSpeed;

        // Draw the square
        Raylib.DrawRectangle((int)squarePosition.X, (int)squarePosition.Y, squareSize, squareSize, Raylib_cs.Color.RayWhite);

        // Draw the text at the top of the screen
        Raylib.DrawText("You're a cube", 400, 100, 60, Raylib_cs.Color.White);
    }
}
