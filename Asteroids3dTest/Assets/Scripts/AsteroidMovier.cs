using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovier : MonoBehaviour
{
    private float asteroid_speed = 10;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * asteroid_speed * -1;
    }
}
