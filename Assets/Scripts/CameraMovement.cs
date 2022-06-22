using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject butcher;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posButcherX = butcher.transform.position.x;
        float minX = -15f;
        float maxX = 0;
        
        if(transform.position.x >= minX && transform.position.x <= maxX){
            Vector3 pos = new Vector3(butcher.transform.position.x, 0, -10);
            transform.position = pos * 2f;

        }

        if(transform.position.x < minX ){
            Vector3 pos = new Vector3(minX, 0, -10);
            transform.position = pos;

        }

        if(transform.position.x > maxX){
            Vector3 pos = new Vector3(maxX, 0, -10);
            transform.position = pos;

        }

    }
}
