using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public float force;
    public GameObject ball;
    public Movement movement;
    public Vector3 victor;
    public float rapid;
    private AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = this.GetComponent<AudioSource>();
        if (rapid <= 0)
            rapid = .1f;
        StartCoroutine(cubeSpawn());
    }

     IEnumerator cubeSpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(rapid);
            GameObject b = Instantiate<GameObject>(ball, this.transform.position, this.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(victor * force);
            a.Play();
        }
    }
    

    // Update is called once per frame
    /**
    void Update()
    {
        return;
        /**
        if(movement.getSpace())
        {
            GameObject b = Instantiate(ball, this.transform.position, this.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(victor * force);
        }
        
    }
    */
}
