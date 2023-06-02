//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Basic.GravityComponent gravity { get { return (FlappyBird.Gameplay.Basic.GravityComponent)GetComponent(LevelComponentsLookup.Gravity); } }
    public bool hasGravity { get { return HasComponent(LevelComponentsLookup.Gravity); } }

    public void AddGravity(float newAcceleration) {
        var index = LevelComponentsLookup.Gravity;
        var component = (FlappyBird.Gameplay.Basic.GravityComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.GravityComponent));
        component.Acceleration = newAcceleration;
        AddComponent(index, component);
    }

    public void ReplaceGravity(float newAcceleration) {
        var index = LevelComponentsLookup.Gravity;
        var component = (FlappyBird.Gameplay.Basic.GravityComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.GravityComponent));
        component.Acceleration = newAcceleration;
        ReplaceComponent(index, component);
    }

    public void RemoveGravity() {
        RemoveComponent(LevelComponentsLookup.Gravity);
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

    static Entitas.IMatcher<LevelEntity> _matcherGravity;

    public static Entitas.IMatcher<LevelEntity> Gravity {
        get {
            if (_matcherGravity == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.Gravity);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherGravity = matcher;
            }

            return _matcherGravity;
        }
    }
}