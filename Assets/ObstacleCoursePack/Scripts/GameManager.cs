using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public bool menuOn = true;
    public void gameStart()
    {
        menu.SetActive(false);
        menuOn = false;

    }
    void Start()
    {
        Cursor.visible = true; 
        
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
