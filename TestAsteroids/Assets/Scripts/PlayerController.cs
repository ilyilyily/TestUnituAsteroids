﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void FixedUpdate()
    { float moveHorizontal = Input.GetAxis{ "Horizontal"};
        float moveVertical = Input.GetAxis{ "Vertical"};

        Vector3 movement = new Vector3 { moveHorizontal, 0.0f, moveVertical};
        Rigidbody.velocty = movement;
    }
}
