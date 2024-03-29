//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelEntity {

    static readonly FlappyBird.Gameplay.Core.ActiveComponent activeComponent = new FlappyBird.Gameplay.Core.ActiveComponent();

    public bool isActive {
        get { return HasComponent(LevelComponentsLookup.Active); }
        set {
            if (value != isActive) {
                var index = LevelComponentsLookup.Active;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : activeComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<LevelEntity> _matcherActive;

    public static Entitas.IMatcher<LevelEntity> Active {
        get {
            if (_matcherActive == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.Active);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherActive = matcher;
            }

            return _matcherActive;
        }
    }
}
