//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Transforms.RotationClampComponent rotationClamp { get { return (FlappyBird.Gameplay.Transforms.RotationClampComponent)GetComponent(LevelComponentsLookup.RotationClamp); } }
    public bool hasRotationClamp { get { return HasComponent(LevelComponentsLookup.RotationClamp); } }

    public void AddRotationClamp(float newMinValue, float newMaxValue) {
        var index = LevelComponentsLookup.RotationClamp;
        var component = (FlappyBird.Gameplay.Transforms.RotationClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Transforms.RotationClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        AddComponent(index, component);
    }

    public void ReplaceRotationClamp(float newMinValue, float newMaxValue) {
        var index = LevelComponentsLookup.RotationClamp;
        var component = (FlappyBird.Gameplay.Transforms.RotationClampComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Transforms.RotationClampComponent));
        component.MinValue = newMinValue;
        component.MaxValue = newMaxValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRotationClamp() {
        RemoveComponent(LevelComponentsLookup.RotationClamp);
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

    static Entitas.IMatcher<LevelEntity> _matcherRotationClamp;

    public static Entitas.IMatcher<LevelEntity> RotationClamp {
        get {
            if (_matcherRotationClamp == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.RotationClamp);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherRotationClamp = matcher;
            }

            return _matcherRotationClamp;
        }
    }
}