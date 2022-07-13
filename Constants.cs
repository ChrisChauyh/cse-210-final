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
        public float[] heights{ get; set; } = new float[Constants.MAX_COLUMNS];
        public float[] position_x{ get; set; } = new float[Constants.MAX_COLUMNS];
        public float[] position_z{ get; set; } = new float[Constants.MAX_COLUMNS];
        public Vector3[] positions{ get; set; } = new Vector3[Constants.MAX_COLUMNS];
        public Raylib_cs.Color[] colors{ get; set; } = new Raylib_cs.Color[Constants.MAX_COLUMNS];
        

        //timer
        public int framesCounter{ get; set; } = 480;
        //collision checker
        public bool collision = false;


    }
}

