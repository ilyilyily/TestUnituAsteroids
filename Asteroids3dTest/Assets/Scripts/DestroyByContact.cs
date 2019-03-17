using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public int ScoreValue;
    public GameView /*имя класа (типа)*/ GameView /*собственное имя*/;

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
