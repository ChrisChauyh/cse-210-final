using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace csefinal.Game.Casting
{
    public class Cubes:Constants
    {
        public Cubes()
        {
        }

        //create random cubes
        public void createcubes()
        {
             for (int i = 0; i < Constants.MAX_COLUMNS; i++)
            {
                if (GetTime() > 6) // Get elapsed time in seconds since InitWindow() 
                {
                    DrawCube(positions[i], 2.0f, heights[i], 2.0f, colors[i]);
                    DrawCubeWires(positions[i], 2.0f, heights[i], 2.0f, MAROON);
                }
            }
        }

        public void generatecubepositions()
        {
            for (int i = 0; i < Constants.MAX_COLUMNS; i++)
                    {
                        heights[i] = (float)GetRandomValue(1, 12);
                        position_x[i] = (float)GetRandomValue(-15, 15);
                   position_z[i] = (float)GetRandomValue(-15, 15);
                  positions[i] = new Vector3(position_x[i], heights[i] / 2, position_z[i]);
                  colors[i] = new Raylib_cs.Color(GetRandomValue(20, 255), GetRandomValue(10, 55), 30, 255);

                    }
        }



    }
}