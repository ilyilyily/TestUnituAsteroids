using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt: MonoBehaviour
{
    public float bolt_speed;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * bolt_speed;
    }
}
