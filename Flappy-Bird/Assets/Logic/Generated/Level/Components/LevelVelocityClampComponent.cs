//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Basic.VelocityClampComponent velocityClamp { get { return (FlappyBird.Gameplay.Basic.VelocityClampComponent)GetComponent(LevelComponentsLookup.VelocityClamp); } }
    public bool hasVelocityClamp { get { return HasComponent(LevelComponentsLookup.VelocityClamp); } }

    public void AddVelocityClamp(UnityEngine.Vector2 newMinValue, UnityEngine.Vector2 newMaxValue) {
        var index = LevelComponentsLookup.VelocityClamp;
        var component = (FlappyBird.Gameplay.Basic.VelocityClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.VelocityClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        AddComponent(index, component);
    }

    public void ReplaceVelocityClamp(UnityEngine.Vector2 newMinValue, UnityEngine.Vector2 newMaxValue) {
        var index = LevelComponentsLookup.VelocityClamp;
        var component = (FlappyBird.Gameplay.Basic.VelocityClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.VelocityClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVelocityClamp() {
        RemoveComponent(LevelComponentsLookup.VelocityClamp);
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

    static Entitas.IMatcher<LevelEntity> _matcherVelocityClamp;

    public static Entitas.IMatcher<LevelEntity> VelocityClamp {
        get {
            if (_matcherVelocityClamp == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.VelocityClamp);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherVelocityClamp = matcher;
            }

            return _matcherVelocityClamp;
        }
    }
}
