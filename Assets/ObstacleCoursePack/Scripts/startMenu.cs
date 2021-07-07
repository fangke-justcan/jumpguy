using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playButtionClick()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }

    public void quitButtonClick()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000 * Time.deltaTime, 0));
        
    }
}
