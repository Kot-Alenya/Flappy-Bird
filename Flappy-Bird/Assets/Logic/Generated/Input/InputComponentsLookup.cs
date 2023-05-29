//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class InputComponentsLookup {

    public const int GameOver = 0;
    public const int ScoreAdd = 1;
    public const int FlyUp = 2;
    public const int Collision = 3;
    public const int Event = 4;
    public const int Time = 5;

    public const int TotalComponents = 6;

    public static readonly string[] componentNames = {
        "GameOver",
        "ScoreAdd",
        "FlyUp",
        "Collision",
        "Event",
        "Time"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(FlappyBird.Ecs.Basic.GameOver.GameOverComponent),
        typeof(FlappyBird.Ecs.Basic.GameOver.ScoreAddComponent),
        typeof(FlappyBird.Ecs.Gameplay.Bird.FlyUpComponent),
        typeof(FlappyBird.Gameplay.Basic.CollisionComponent),
        typeof(FlappyBird.Gameplay.Basic.EventComponent),
        typeof(FlappyBird.Gameplay.Basic.TimeComponent)
    };
}
