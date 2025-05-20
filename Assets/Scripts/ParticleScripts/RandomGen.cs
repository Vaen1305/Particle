using UnityEngine;
using System;

public static class RandomGen
{
    private static readonly System.Random rng = new System.Random();

    public static float NextFloat(float min, float max)
    {
        return (float)(rng.NextDouble() * (max - min) + min);
    }
}