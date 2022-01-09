using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haraket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float kamerahizi = Time.deltaTime * 5f;
        transform.Translate(0, 0, kamerahizi);
    }
}
