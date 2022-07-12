


namespace csefinal.Game.Casting
{
    public class Point
    {
        private int point = 0;

        public int AddPoints(int framesCounter)
        {  
            //Every Round add one new point.
            if(framesCounter ==122)
            {
                point ++;
            }
            return point;
        }



    }
}