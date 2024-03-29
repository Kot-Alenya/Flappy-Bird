//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Core.VelocityComponent velocity { get { return (FlappyBird.Gameplay.Core.VelocityComponent)GetComponent(LevelComponentsLookup.Velocity); } }
    public bool hasVelocity { get { return HasComponent(LevelComponentsLookup.Velocity); } }

    public void AddVelocity(UnityEngine.Vector2 newValue) {
        var index = LevelComponentsLookup.Velocity;
        var component = (FlappyBird.Gameplay.Core.VelocityComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.VelocityComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVelocity(UnityEngine.Vector2 newValue) {
        var index = LevelComponentsLookup.Velocity;
        var component = (FlappyBird.Gameplay.Core.VelocityComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.VelocityComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVelocity() {
        RemoveComponent(LevelComponentsLookup.Velocity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class LevelMatcher {

    static Entitas.IMatcher<LevelEntity> _matcherVelocity;

    public static Entitas.IMatcher<LevelEntity> Velocity {
        get {
            if (_matcherVelocity == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.Velocity);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherVelocity = matcher;
            }

            return _matcherVelocity;
        }
    }
}
