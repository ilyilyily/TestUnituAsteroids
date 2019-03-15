﻿using UnityEngine;
using System.Collections;

[System.Serializable]


public class Player : MonoBehaviour
{

    void FixedUpdate()
    {
        float moveHorizontal = PlayerModel.GetMoveHorizontal();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * PlayerModel.ship_speed;

    }


}