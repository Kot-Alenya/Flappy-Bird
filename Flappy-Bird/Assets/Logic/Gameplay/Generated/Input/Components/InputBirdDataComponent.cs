//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity birdDataEntity { get { return GetGroup(InputMatcher.BirdData).GetSingleEntity(); } }
    public FlappyBird.Gameplay.Core.Bird.BirdDataComponent birdData { get { return birdDataEntity.birdData; } }
    public bool hasBirdData { get { return birdDataEntity != null; } }

    public InputEntity SetBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity) {
        if (hasBirdData) {
            throw new Entitas.EntitasException("Could not set BirdData!\n" + this + " already has an entity with FlappyBird.Gameplay.Core.Bird.BirdDataComponent!",
                "You should check if the context already has a birdDataEntity before setting it or use context.ReplaceBirdData().");
        }
        var entity = CreateEntity();
        entity.AddBirdData(newFlyUpAction, newFlyUpVelocity);
        return entity;
    }

    public void ReplaceBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity) {
        var entity = birdDataEntity;
        if (entity == null) {
            entity = SetBirdData(newFlyUpAction, newFlyUpVelocity);
        } else {
            entity.ReplaceBirdData(newFlyUpAction, newFlyUpVelocity);
        }
    }

    public void RemoveBirdData() {
        birdDataEntity.Destroy();
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

    public FlappyBird.Gameplay.Core.Bird.BirdDataComponent birdData { get { return (FlappyBird.Gameplay.Core.Bird.BirdDataComponent)GetComponent(InputComponentsLookup.BirdData); } }
    public bool hasBirdData { get { return HasComponent(InputComponentsLookup.BirdData); } }

    public void AddBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity) {
        var index = InputComponentsLookup.BirdData;
        var component = (FlappyBird.Gameplay.Core.Bird.BirdDataComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.Bird.BirdDataComponent));
        component.FlyUpAction = newFlyUpAction;
        component.FlyUpVelocity = newFlyUpVelocity;
        AddComponent(index, component);
    }

    public void ReplaceBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity) {
        var index = InputComponentsLookup.BirdData;
        var component = (FlappyBird.Gameplay.Core.Bird.BirdDataComponent)CreateComponent(index, typeof(FlappyBird.Gameplay.Core.Bird.BirdDataComponent));
        component.FlyUpAction = newFlyUpAction;
        component.FlyUpVelocity = newFlyUpVelocity;
        ReplaceComponent(index, component);
    }

    public void RemoveBirdData() {
        RemoveComponent(InputComponentsLookup.BirdData);
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

    static Entitas.IMatcher<InputEntity> _matcherBirdData;

    public static Entitas.IMatcher<InputEntity> BirdData {
        get {
            if (_matcherBirdData == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.BirdData);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherBirdData = matcher;
            }

            return _matcherBirdData;
        }
    }
}
