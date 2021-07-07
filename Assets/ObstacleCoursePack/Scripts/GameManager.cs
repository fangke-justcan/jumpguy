using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainMenu;
    public GameObject optionMenu;
    public Slider VolumeSlider;
  
    public bool ifWin;
    public bool menuOn = false;
    public enum GameMode { MainMenu, OptionMenu, Play , Die, Win};
    public GameMode gm;

    public int lifeLeft = 10;
    public float timePaused = 0f;
    float pauseStartTime = 0;
    public void resumeButtionClicked()
    {

        mainMenu.SetActive(false);
        menuOn = false;
        Time.timeScale = 1;
        gm = GameMode.Play;
        timePaused += (Time.timeSinceLevelLoad - pauseStartTime);
    }
    
    public void quitButtionClicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        
    }

    public void optionButtonClicked()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
        gm = GameMode.OptionMenu;

    }
    public void optionBackClicked()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
        gm = GameMode.MainMenu;
    }

    public void volumeChange()
    {
         GetComponent<AudioSource>().volume = VolumeSlider.value ;
           // Debug.Log(GetComponent<AudioSource>().volume); 
    }

    void Start()
    {
        Cursor.visible = true;
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        optionMenu.SetActive(false);
        menuOn = false;
        gm = GameMode.Play;
        VolumeSlider.value = 0.5f;
        GetComponent<AudioSource>().volume = 0.5f;
        timePaused = 0;
        pauseStartTime = 0;
        ifWin = false;
        lifeLeft = 10;
        
    }

    // Update is called once per frame 
    void Update()
    {
        
        switch (gm)
        {
            case GameMode.MainMenu:


                break;
            case GameMode.OptionMenu:


                break;
            case GameMode.Play:
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    menuOn = true;
                    mainMenu.SetActive(true);
                    Time.timeScale = 0;
                    pauseStartTime = Time.timeSinceLevelLoad;
                }

                if (lifeLeft <=0)
                {
                    lifeLeft = 0;
                    gm = GameMode.Die;
                }
                
                
                if (ifWin)
                {
                    gm = GameMode.Win;
                }

                break;
            case GameMode.Die:
                Debug.Log("Died - Reseting");
                SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
              
                break;
            case GameMode.Win:
                Debug.Log("Win - Reseting");
                SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
                


                break;


        } 
              
        
        
    }
}
