﻿public class DeltaTime
{
    public float Value { get; private set; }

    public void SetValue(float newValue)
        => Value = newValue;
}