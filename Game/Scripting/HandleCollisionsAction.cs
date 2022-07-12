using System;
using System.Collections.Generic;
using System.Data;
using csefinal.Game.Casting;
using csefinal.Game.Services;


namespace csefinal.Game.Scripting
{

    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
          //  Snake snake = (Snake)cast.GetFirstActor("snake");
            Cubes food = (Cubes)cast.GetFirstActor("food");
            

          //  if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
         //   {
          //      int points = food.GetPoints();
         //       snake.GrowTail(points);
         //       score.AddPoints(points);
         //       food.Reset();
         //   }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
           // Snake snake = (Snake)cast.GetFirstActor("snake");
          //  Actor head = snake.GetHead();
          //  List<Actor> body = snake.GetBody();

         //   foreach (Actor segment in body)
         //   {
           //     if (segment.GetPosition().Equals(head.GetPosition()))
            //    {
           //         isGameOver = true;
           //     }
         //   }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
              //  Snake snake = (Snake)cast.GetFirstActor("snake");
              //  List<Actor> segments = snake.GetSegments();
                //Food food = (Food)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;

                Actor message = new Actor();
                message.SetText("Game Over!");
                cast.AddActor("cube", message);

                // make everything white
              //  foreach (Actor segment in segments)
            //    {
                    //segment.SetColor(Constants.WHITE);
            //    }
                //food.SetColor(Constants.WHITE);
            }
        }

    }
}