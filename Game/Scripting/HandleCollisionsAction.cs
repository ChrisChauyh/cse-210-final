using csefinal.Game.Casting;
using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using csefinal.Game.Services;


namespace csefinal.Game.Scripting
{

    public class HandleCollisionsAction : VideoService
    {

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        private void HandleGameOver()
        {
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
                        Color transparent = new Color(230, 41, 55, 40);
                        DrawRectangle(0, 0, Constants.MAX_X, Constants.MAX_Y, transparent);
                        DrawText("You Lost!!!", Constants.MAX_X / 2 - 100, Constants.MAX_Y / 2 - 140, 80, DARKBLUE);
                        DrawText("PRESS ESC to exit game.", Constants.MAX_X / 2 - 150, Constants.MAX_Y / 2, 20, DARKBLUE);
                    }
                }
        }

    }
}