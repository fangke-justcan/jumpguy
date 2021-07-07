using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class lifetext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Life: " + FindObjectOfType<GameManager>().lifeLeft;

    }
}
