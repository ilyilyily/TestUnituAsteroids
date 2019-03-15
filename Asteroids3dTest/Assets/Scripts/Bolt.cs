using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt: MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * BoltModel.bolt_speed;
    }
}
