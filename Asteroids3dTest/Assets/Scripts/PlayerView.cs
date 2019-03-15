using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis { "Horizontal"};
        float MoveVertical = Input.GetAxis { "Vertical"};

        Vector3 movement new Vector3 { MoveHorizontal , 0.0f, MoveVertical }
        rigidbody.velocity = movement;
    }
}
