using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisbleWall : MonoBehaviour
{
    Renderer r;
    [SerializeField] public bool setFalse;
    // Start is called before the first frame update
    void Start()
    {
        setFalse = false;
        r = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(setFalse);
        if(setFalse)
        r.enabled = false;
        else
        r.enabled = true;

    }
}
