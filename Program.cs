﻿using csefinal.Game.Casting;
using csefinal.Game.Directing;
using csefinal.Game.Scripting;
using csefinal.Game.Services;


namespace csefinal
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            cast.AddActor("cubes", new Cubes());

            // create the services
            VideoService videoService = new VideoService();
           
            // create the script
            Script script = new Script();
            script.AddAction("update", new HandleCollisionsAction());

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}