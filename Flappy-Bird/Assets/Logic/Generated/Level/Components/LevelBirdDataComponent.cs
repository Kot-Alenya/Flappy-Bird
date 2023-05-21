//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class LevelContext {

    public LevelEntity birdDataEntity { get { return GetGroup(LevelMatcher.BirdData).GetSingleEntity(); } }
    public FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent birdData { get { return birdDataEntity.birdData; } }
    public bool hasBirdData { get { return birdDataEntity != null; } }

    public LevelEntity SetBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity, float newClockwiseAngularVelocity, float newCounterClockwiseAngularVelocity, float newVelocityToFlyRotation, float newVelocityToFallRotation) {
        if (hasBirdData) {
            throw new Entitas.EntitasException("Could not set BirdData!\n" + this + " already has an entity with FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent!",
                "You should check if the context already has a birdDataEntity before setting it or use context.ReplaceBirdData().");
        }
        var entity = CreateEntity();
        entity.AddBirdData(newFlyUpAction, newFlyUpVelocity, newClockwiseAngularVelocity, newCounterClockwiseAngularVelocity, newVelocityToFlyRotation, newVelocityToFallRotation);
        return entity;
    }

    public void ReplaceBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity, float newClockwiseAngularVelocity, float newCounterClockwiseAngularVelocity, float newVelocityToFlyRotation, float newVelocityToFallRotation) {
        var entity = birdDataEntity;
        if (entity == null) {
            entity = SetBirdData(newFlyUpAction, newFlyUpVelocity, newClockwiseAngularVelocity, newCounterClockwiseAngularVelocity, newVelocityToFlyRotation, newVelocityToFallRotation);
        } else {
            entity.ReplaceBirdData(newFlyUpAction, newFlyUpVelocity, newClockwiseAngularVelocity, newCounterClockwiseAngularVelocity, newVelocityToFlyRotation, newVelocityToFallRotation);
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
public partial class LevelEntity {

    public FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent birdData { get { return (FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent)GetComponent(LevelComponentsLookup.BirdData); } }
    public bool hasBirdData { get { return HasComponent(LevelComponentsLookup.BirdData); } }

    public void AddBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity, float newClockwiseAngularVelocity, float newCounterClockwiseAngularVelocity, float newVelocityToFlyRotation, float newVelocityToFallRotation) {
        var index = LevelComponentsLookup.BirdData;
        var component = (FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent)CreateComponent(index, typeof(FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent));
        component.FlyUpAction = newFlyUpAction;
        component.FlyUpVelocity = newFlyUpVelocity;
        component.ClockwiseAngularVelocity = newClockwiseAngularVelocity;
        component.CounterClockwiseAngularVelocity = newCounterClockwiseAngularVelocity;
        component.VelocityToFlyRotation = newVelocityToFlyRotation;
        component.VelocityToFallRotation = newVelocityToFallRotation;
        AddComponent(index, component);
    }

    public void ReplaceBirdData(UnityEngine.InputSystem.InputAction newFlyUpAction, float newFlyUpVelocity, float newClockwiseAngularVelocity, float newCounterClockwiseAngularVelocity, float newVelocityToFlyRotation, float newVelocityToFallRotation) {
        var index = LevelComponentsLookup.BirdData;
        var component = (FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent)CreateComponent(index, typeof(FlappyBird.Ecs.Gameplay.Bird.BirdDataComponent));
        component.FlyUpAction = newFlyUpAction;
        component.FlyUpVelocity = newFlyUpVelocity;
        component.ClockwiseAngularVelocity = newClockwiseAngularVelocity;
        component.CounterClockwiseAngularVelocity = newCounterClockwiseAngularVelocity;
        component.VelocityToFlyRotation = newVelocityToFlyRotation;
        component.VelocityToFallRotation = newVelocityToFallRotation;
        ReplaceComponent(index, component);
    }

    public void RemoveBirdData() {
        RemoveComponent(LevelComponentsLookup.BirdData);
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

    static Entitas.IMatcher<LevelEntity> _matcherBirdData;

    public static Entitas.IMatcher<LevelEntity> BirdData {
        get {
            if (_matcherBirdData == null) {
                var matcher = (Entitas.Matcher<LevelEntity>)Entitas.Matcher<LevelEntity>.AllOf(LevelComponentsLookup.BirdData);
                matcher.componentNames = LevelComponentsLookup.componentNames;
                _matcherBirdData = matcher;
            }

            return _matcherBirdData;
        }
    }
}
