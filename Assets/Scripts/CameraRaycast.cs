using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    private int mask = (1 << 8);
    private bool hitting;
    private InvisbleWall priorHit;

    public Transform person;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
       RaycastHit[] hit;
        // Does the ray intersect any objects excluding the player layer
        hit = Physics.RaycastAll(transform.position,  person.transform.position - transform.position, 5f, mask);
        Debug.DrawRay(transform.position,  person.transform.position - transform.position, Color.yellow);
        hitting = false;
        for (int i = 0; i < hit.Length; i++)
        {
            RaycastHit h = hit[i];
            InvisbleWall iw = h.transform.GetComponent<InvisbleWall>();
            Debug.Log(h);
            if(iw)
            {
            iw.setFalse = true;
            hitting = true;
            priorHit = iw;
            }
        }
        if((priorHit) && !hitting)
        {    
            priorHit.setFalse = false;
            priorHit = null;
        }
        /**
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        */
    }
}
