using System.Numerics;
using projekt1;
using Raylib_cs;

Raylib.InitWindow(1000, 800, "Game");
Raylib.SetTargetFPS(60);

Character dog = new Character();

while (!Raylib.WindowShouldClose())
{

dog.Movement();



Raylib.BeginDrawing();
Raylib.ClearBackground(Color.SkyBlue);
dog.DrawCharacter();

Raylib.EndDrawing();

}