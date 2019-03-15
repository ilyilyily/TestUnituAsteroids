using UnityEngine;
using System.Collections;

[System.Serializable]


public class Player : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        float moveHorizontal = PlayerModel.GetMoveHorizontal();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f); 
        GetComponent<Rigidbody>().velocity = movement * speed;

    }

    
}