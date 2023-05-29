//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public FlappyBird.Gameplay.Basic.CollisionComponent collision { get { return (FlappyBird.Gameplay.Basic.CollisionComponent)GetComponent(InputComponentsLookup.Collision); } }
    public bool hasCollision { get { return HasComponent(InputComponentsLookup.Collision); } }

    public void AddCollision(UnityEngine.Collision2D newInfo) {
        var index = InputComponentsLookup.Collision;
        var component = (FlappyBird.Gameplay.Basic.CollisionComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.CollisionComponent));
        component.Info = newInfo;
        AddComponent(index, component);
    }

    public void ReplaceCollision(UnityEngine.Collision2D newInfo) {
        var index = InputComponentsLookup.Collision;
        var component = (FlappyBird.Gameplay.Basic.CollisionComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Basic.CollisionComponent));
        component.Info = newInfo;
        ReplaceComponent(index, component);
    }

    public void RemoveCollision() {
        RemoveComponent(InputComponentsLookup.Collision);
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

    static Entitas.IMatcher<InputEntity> _matcherCollision;

    public static Entitas.IMatcher<InputEntity> Collision {
        get {
            if (_matcherCollision == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Collision);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherCollision = matcher;
            }

            return _matcherCollision;
        }
    }
}
