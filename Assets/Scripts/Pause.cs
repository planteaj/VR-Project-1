using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Movement movement;

    [SerializeField] private GameObject menu;
    [SerializeField] private bool pause;

    public Scoring s;

    
    // Start is called before the first frame update
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(movement.getEscape())
       {
          pause = !pause; 
       }

       if(pause)
       {
           Activate();
       }
       else Deactivate();

    }

    void Activate()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
    }

    public void Deactivate() 
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    public bool getPause() {
        return pause;
    }

    public void exit() 
    {
        Application.Quit();
    }

    public void reset() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        s.setScore(0);
    }
}
