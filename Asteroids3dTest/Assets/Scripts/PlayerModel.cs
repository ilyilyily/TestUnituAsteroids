﻿using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin = -11, xMax = 11;
}

public class PlayerModel
{
    public static float ship_speed = 5;
    public static float GetMoveHorizontal()
    {
        return Input.GetAxis("Horizontal");

    }


}
