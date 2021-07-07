using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class timeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gm == GameManager.GameMode.Play) 
            GetComponent<TextMeshProUGUI>().text = "Time: " + (int)(Time.timeSinceLevelLoad - FindObjectOfType<GameManager>().timePaused);
      
    }
}
