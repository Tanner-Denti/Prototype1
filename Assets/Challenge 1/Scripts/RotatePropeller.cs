using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    // create a variable with a set sping speed of 5
    public Vector3 zAxisRotation = new Vector3(0, 0, 5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the propeller
        transform.Rotate(zAxisRotation);
    }
}
