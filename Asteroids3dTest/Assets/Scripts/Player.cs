using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin = -12, xMax = 12;
}

public class Player : MonoBehaviour
{

    void FixedUpdate()
    {
        float moveHorizontal = PlayerModel.GetMoveHorizontal();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * PlayerModel.ship_speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            0.0f
        );
    }


}