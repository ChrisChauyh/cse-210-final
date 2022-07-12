using csefinal.Game.Casting;
using csefinal.Game.Scripting;
using csefinal.Game.Services;
using static Raylib_cs.Raylib;


namespace csefinal.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private VideoService videoService = null;

        /// <summary>
        /// Constructs a new instance of Director using the given VideoService.
        /// </summary>
        /// <param name="videoService">The given VideoService.</param>
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
        }
        //start the game
        public void StartGame(Cast cast, Script script)
        {
            videoService.OpenWindow();
            while (!WindowShouldClose())
            {
                videoService.Mainloop();
            }
        }
    }
}