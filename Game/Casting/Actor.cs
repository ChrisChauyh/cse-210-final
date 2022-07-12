using System;


namespace csefinal.Game.Casting
{
    public class Actor
    {
        private string text = "";
        Constants constants = new Constants();

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor()
        {
        }
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }


    }
}