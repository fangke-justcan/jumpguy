using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wining : MonoBehaviour
{
    // Start is called before the first frame update
   

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().ifWin = true;

        }
    }
}
