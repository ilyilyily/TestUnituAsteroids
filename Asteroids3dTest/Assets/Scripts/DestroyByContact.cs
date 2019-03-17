using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public int ScoreValue;
    private GameView /*имя класа (типа)*/ GameView /*собственное имя*/;

    private void Start()
    {
        GameObject GameControllerObject = GameObject.FindWithTag("GameController");
        if(GameControllerObject != null)
        {
            GameView = GameControllerObject.GetComponent<GameView>();
        }

        if (GameView == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return; //если соприкосается с Границой - ничего не происхоодит
        }

        GameView.AddScore(ScoreValue);
        Destroy(other.gameObject); // уничтожает объект который прикоснулся
        Destroy(gameObject); // уничтожает самого себя
    }
}
