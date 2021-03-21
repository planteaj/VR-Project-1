using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterLerp : MonoBehaviour
{
    public Transform a;
    public Transform b;
    public float timeMax = 5;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(0, timeMax);
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        float pos = (Mathf.Sin(2 * Mathf.PI * t / time) + 1) / (2.0f);
        transform.position = Vector3.Lerp(a.position, b.position, pos);
  
    }
}
