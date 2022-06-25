using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideCameras : MonoBehaviour
{
    public GameObject firstCamera;
    public GameObject secondCamera;
    
    [SerializeField] private Moving moving;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        
        firstCamera.SetActive(false);
        secondCamera.SetActive(true);
        // moving.GetComponent<Moving>().enabled = false;
        
    }
    private void OnCollisionExit2D(Collision2D other) {
       
            firstCamera.SetActive(true);
            secondCamera.SetActive(false);
    }
}
