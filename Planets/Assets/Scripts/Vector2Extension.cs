﻿using UnityEngine;

public static class Vector2Extension
{

    public static Vector2 Rotate(this Vector2 vector, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tempX = vector.x;
        float tempY = vector.y;
        vector.x = (cos * tempX) - (sin * tempY);
        vector.y = (sin * tempX) + (cos * tempY);
        return vector;
    }
}