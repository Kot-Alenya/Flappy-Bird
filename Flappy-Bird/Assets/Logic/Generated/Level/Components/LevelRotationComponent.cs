//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Basic.RotationComponent rotation { get { return (FlappyBird.Gameplay.Basic.RotationComponent)GetComponent(LevelComponentsLookup.Rotation); } }
    public bool hasRotation { get { return HasComponent(LevelComponentsLookup.Rotation); } }

    public void AddRotation(float newValue) {
        var index = LevelComponentsLookup.Rotation;
        var component = (FlappyBird.Gameplay.Basic.RotationComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.RotationComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRotation(float newValue) {
        var index = LevelComponentsLookup.Rotation;
        var component = (FlappyBird.Gameplay.Basic.RotationComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.RotationComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRotation() {
        RemoveComponent(LevelComponentsLookup.Rotation);
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

    static Entitas.IMatcher<LevelEntity> _matcherRotation;

    public static Entitas.IMatcher<LevelEntity> Rotation {
        get {
            if (_matcherRotation == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.Rotation);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherRotation = matcher;
            }

            return _matcherRotation;
        }
    }
}
