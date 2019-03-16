using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin = -11, xMax = 11;
}

public class Player : MonoBehaviour
{
    public Boundary boundary;
    void FixedUpdate()
    {
        float moveHorizontal = PlayerModel.GetMoveHorizontal();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * PlayerModel.ship_speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            2.0f,
            -4.1f
        );
    }


}