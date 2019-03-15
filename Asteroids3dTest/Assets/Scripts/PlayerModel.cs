using UnityEngine;

[System.Serializable]


public class PlayerModel : MonoBehaviour
{
    public static float ship_speed = 5;
    public static float GetMoveHorizontal()
    {
        return Input.GetAxis("Horizontal");



    }


}
