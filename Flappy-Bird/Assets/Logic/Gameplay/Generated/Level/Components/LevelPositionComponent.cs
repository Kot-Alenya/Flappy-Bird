//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    public FlappyBird.Gameplay.Core.PositionComponent position { get { return (FlappyBird.Gameplay.Core.PositionComponent)GetComponent(LevelComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(LevelComponentsLookup.Position); } }

    public void AddPosition(UnityEngine.Vector2 newValue) {
        var index = LevelComponentsLookup.Position;
        var component = (FlappyBird.Gameplay.Core.PositionComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.PositionComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePosition(UnityEngine.Vector2 newValue) {
        var index = LevelComponentsLookup.Position;
        var component = (FlappyBird.Gameplay.Core.PositionComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.PositionComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(LevelComponentsLookup.Position);
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

    static Entitas.IMatcher<LevelEntity> _matcherPosition;

    public static Entitas.IMatcher<LevelEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.Position);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}
