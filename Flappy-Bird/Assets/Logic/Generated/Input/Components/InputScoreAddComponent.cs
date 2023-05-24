//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity scoreAddEntity { get { return GetGroup(InputMatcher.ScoreAdd).GetSingleEntity(); } }

    public bool isScoreAdd {
        get { return scoreAddEntity != null; }
        set {
            var entity = scoreAddEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isScoreAdd = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly FlappyBird.Ecs.Basic.GameOver.ScoreAddComponent scoreAddComponent = new FlappyBird.Ecs.Basic.GameOver.ScoreAddComponent();

    public bool isScoreAdd {
        get { return HasComponent(InputComponentsLookup.ScoreAdd); }
        set {
            if (value != isScoreAdd) {
                var index = InputComponentsLookup.ScoreAdd;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : scoreAddComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherScoreAdd;

    public static Entitas.IMatcher<InputEntity> ScoreAdd {
        get {
            if (_matcherScoreAdd == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.ScoreAdd);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherScoreAdd = matcher;
            }

            return _matcherScoreAdd;
        }
    }
}
