using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingCube : MonoBehaviour
{
    float DperSec = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DperSec = DperSec * Time.deltaTime;
        this.transform.Rotate(0, DperSec, 0);
    }
}
