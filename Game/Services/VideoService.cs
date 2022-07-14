using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.CameraProjection;
using static Raylib_cs.CameraMode;
using static Raylib_cs.Color;
using csefinal.Game.Casting;
using csefinal.Game.Scripting;

namespace csefinal.Game.Services
{
    public class VideoService 
    {
        public Camera3D camera = new Camera3D();
        public Constants constants = new Constants();
        public HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction();
        Point point = new Point();
        Cubes cubes = new Cubes();


        public void OpenWindow()
        {
            Raylib.InitWindow(Constants.MAX_X, Constants.MAX_Y, Constants.CAPTION);
            camera.position = new Vector3(4.0f, 2.0f, 4.0f);
            camera.target = new Vector3(0.0f, 1.8f, 0.0f);
            camera.up = new Vector3(0.0f, 1.0f, 0.0f);
            camera.fovy = 90.0f;
            camera.projection = CAMERA_PERSPECTIVE;
            SetCameraMode(camera, CAMERA_FIRST_PERSON); // Set a first person camera mode
            SetTargetFPS(60); // Set our game to run at 60 frames-per-second
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }

        // Open game screem (1 frame)
        public void Mainloop()
        {
            // Update camera
            UpdateCamera(ref camera);
            // Draw
            BeginDrawing();
            ClearBackground(RAYWHITE);
            world_3d();


            DrawText("Next random cubes will appear in:", Constants.MAX_X / 2 - 170, Constants.MAX_Y / 2 - 130, 20, BLACK);
            DrawText($"{constants.framesCounter / 60 - 2}", Constants.MAX_X / 2 - 40, Constants.MAX_Y / 2 - 100, 80, BLACK);

            DrawRectangle(10, 10, 400, 100, ColorAlpha(SKYBLUE, 0.5f));
            DrawRectangleLines(10, 10, 400, 100, BLUE);

            DrawText("Rules:", 20, 20, 20, BLACK);
            DrawText("- Move with keys: W, A, S, D", 40, 40, 20, BLACK);
            DrawText("- Mouse move to look around", 40, 60, 20, BLACK);
            DrawText("- Game rule: Don't walk into cubes!", 40, 80, 20, BLACK);
            DrawText($"Scores: {point.AddPoints(constants.framesCounter)}", Constants.MAX_X-170, 40, 30, BLACK);


            constants.framesCounter--;
            if (GetTime() > 6) // Get elapsed time in seconds since InitWindow() 
            {

                if (constants.framesCounter == 120)
                {
                    constants.framesCounter = 480;
                    cubes.generatecubepositions();
                }
                 for (int i = 0; i < Constants.MAX_COLUMNS; i++)
                {
                    Vector3 playerPosition = new Vector3(camera.position.X, 0.5f, camera.position.Z);
                    Vector3 playerSize = new Vector3(1.0f, 2.0f, 1.0f);
                    Vector3 enemyBoxPos = new Vector3(constants.position_x[i], 0.5f, constants.position_z[i]);
                    Vector3 enemyBoxSize = new Vector3(1.0f, 2.0f, 2.0f);

                    // Check collisions player vs enemy-boxs
                    BoundingBox box1 = new BoundingBox(
                        playerPosition - (playerSize / 2),
                        playerPosition + (playerSize / 2)
                    );
                    BoundingBox box2 = new BoundingBox(
                        enemyBoxPos - (enemyBoxSize / 2),
                        enemyBoxPos + (enemyBoxSize / 2)
                    );
                    // Check collisions player vs enemy-boxs
                    if (CheckCollisionBoxes(box1, box2))
                    {
                        constants.collision = true;
                    }

                    if (constants.collision)
                    {
                        Color transparent = new Color(230, 41, 55, 30);
                        DrawRectangle(0, 0, Constants.MAX_X, Constants.MAX_Y, transparent);
                        DrawText("You Lost!!!", Constants.MAX_X / 2 - 100, Constants.MAX_Y / 2 - 140, 80, DARKBLUE);
                        DrawText("PRESS ESC to exit game.", Constants.MAX_X / 2 - 150, Constants.MAX_Y / 2, 20, DARKBLUE);
                    }
                }
                    
            }
            EndDrawing();
        }
        //draw 3d world
        public void world_3d()
        {
            BeginMode3D(camera);
            //Draw walls
            DrawPlane(new Vector3(0.0f, 0.0f, 0.0f), new Vector2(32.0f, 32.0f), LIGHTGRAY); // Draw ground
            DrawCube(new Vector3(-16.0f, 2.5f, 0.0f), 1.0f, 20.0f, 32.0f, BLUE);     // Draw a Color.blue wall
            DrawCube(new Vector3(16.0f, 2.5f, 0.0f), 1.0f, 20.0f, 32.0f, LIME);      // Draw a Color.green wall
            DrawCube(new Vector3(0.0f, 2.5f, 16.0f), 32.0f, 20.0f, 1.0f, GOLD);      // Draw a Color.yellow wall
            DrawCube(new Vector3(0.0f, 2.5f, -16.0f), 32.0f, 20.0f, 1.0f, RED);      // Draw a Color.Red wall
            // Draw some cubes around
            cubes.createcubes();
            EndMode3D();


        }
    }
}