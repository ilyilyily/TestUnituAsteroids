using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public static float speed = 5;
    public static float GetMoveHorizontal()
    {
        return Input.GetAxis("Horizontal");

    }
}
