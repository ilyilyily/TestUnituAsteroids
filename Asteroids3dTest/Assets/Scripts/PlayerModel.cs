using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public static float GetMoveHorizontal()
    {
        return Input.GetAxis("Horizontal");

    }
    //public static float moveHorizontal = GetMoveHorizontal();
}
