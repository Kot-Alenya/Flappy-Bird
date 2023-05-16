//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent verticalVelocityClamp { get { return (FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent)GetComponent(LevelComponentsLookup.VerticalVelocityClamp); } }
    public bool hasVerticalVelocityClamp { get { return HasComponent(LevelComponentsLookup.VerticalVelocityClamp); } }

    public void AddVerticalVelocityClamp(float newMinValue, float newMaxValue) {
        var index = LevelComponentsLookup.VerticalVelocityClamp;
        var component = (FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        AddComponent(index, component);
    }

    public void ReplaceVerticalVelocityClamp(float newMinValue, float newMaxValue) {
        var index = LevelComponentsLookup.VerticalVelocityClamp;
        var component = (FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Transforms.VerticalVelocityClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVerticalVelocityClamp() {
        RemoveComponent(LevelComponentsLookup.VerticalVelocityClamp);
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

    static Entitas.IMatcher<LevelEntity> _matcherVerticalVelocityClamp;

    public static Entitas.IMatcher<LevelEntity> VerticalVelocityClamp {
        get {
            if (_matcherVerticalVelocityClamp == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.VerticalVelocityClamp);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherVerticalVelocityClamp = matcher;
            }

            return _matcherVerticalVelocityClamp;
        }
    }
}