using csefinal.Game.Casting;


namespace csefinal.Game.Scripting 
{
    public interface Action
    {
        void Execute(Cast cast, Script script);
    }
}