using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return; //если соприкосается с Границой - ничего не происхоодит
        }

        Destroy(other.gameObject); // уничтожает объект который прикоснулся
        Destroy(gameObject); // уничтожает самого себя
    }
}
