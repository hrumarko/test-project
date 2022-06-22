using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 moveVector;
    bool vectorRight = true;
    [Range(0, 10)]public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, moveVector.y);

        if(moveVector.x < 0 && vectorRight){
            Flip();
        }

        if(moveVector.x > 0 && !vectorRight){
            Flip();
        }
        
    }

    void Flip(){
        vectorRight = !vectorRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
