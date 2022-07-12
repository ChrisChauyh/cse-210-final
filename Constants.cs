using System.Numerics;

namespace csefinal.Game
{
    /// <summary>
    /// <para>Data</para>
    /// </summary>
    public class Constants
    {
        //screen width
        public static int MAX_X = 900;
        //screen height
        public static int MAX_Y = 600;
        //set columns
        public const int MAX_COLUMNS = 25;
        //screen frame rate
        public static int FRAME_RATE = 60;
        //screen title
        public static string CAPTION = "Douge";
        public float[] heights = new float[Constants.MAX_COLUMNS];
        public float[] position_x = new float[Constants.MAX_COLUMNS];
        public float[] position_z = new float[Constants.MAX_COLUMNS];
        public Vector3[] positions = new Vector3[Constants.MAX_COLUMNS];
        public Raylib_cs.Color[] colors = new Raylib_cs.Color[Constants.MAX_COLUMNS];
        //timer
        public int framesCounter = 480;
        //collision checker
        public bool collision = false;


    }
}

