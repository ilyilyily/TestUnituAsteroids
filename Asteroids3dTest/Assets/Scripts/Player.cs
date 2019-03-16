using UnityEngine;

[System.Serializable] //??


public class Player : MonoBehaviour
{
    public Boundary boundary;

    public GameObject shot;
    public Transform Shot_spawn; //shotSpawn.transfor,position...

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > PlayerModel.nextFire)
        {
            PlayerModel.nextFire = Time.time + PlayerModel.fireRate;
            GameObject clone =  Instantiate(shot, Shot_spawn.position, Shot_spawn.rotation) as GameObject;
        }
       
    }

    void FixedUpdate()
    {
        float moveHorizontal = PlayerModel.GetMoveHorizontal();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * PlayerModel.ship_speed;

        GetComponent<Rigidbody>().position = PositionRiqidgobyShip();
    }

    private Vector3 PositionRiqidgobyShip()  // TODO:move to model or not?
    {
        return new Vector3
                (
                    Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
                    2.0f,
                    -4.1f
                );
    }
}