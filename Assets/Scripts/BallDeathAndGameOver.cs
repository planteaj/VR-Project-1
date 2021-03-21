using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeathAndGameOver : MonoBehaviour
{
    private int ballCount;
    public int ballLimit;

    public GameObject endMenu;
    // Start is called before the first frame update
    void Start()
    {
       endMenu.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
       if(endCheck())
       {
           endMenu.SetActive(true);
           Time.timeScale = 0f;
       } 
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Destroyable"){
            Destroy(collision.collider.gameObject);
             ballCount++;
        }
    }

    public bool endCheck() {
        if(ballCount >= ballLimit) {
            return true;
        }
        else return false;
    }
}
