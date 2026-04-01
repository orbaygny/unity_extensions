using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtensions 
{
    public static Vector3 ZeroAxis(this Vector3 v, Axis axis)
    {
        switch (axis)
        {
            case Axis.X:
                v.x = 0f;
                break;
            case Axis.Y:
                v.y = 0f;
                break;
            case Axis.Z:
                v.z = 0f;
                break;
        }
        return v;
    }
    public static float ExcludeAxisDistance(this Vector3 v1, Vector3 v2,Axis axis)
    {
        Vector3 tmp1 = v1;
        Vector3 tmp2 = v2;
        tmp1 = tmp1.ZeroAxis(axis);
        tmp2 = tmp2.ZeroAxis(axis);
        return (tmp1 - tmp2).sqrMagnitude;
    }
}
public enum Axis
{
    X,
    Y,
    Z
}
