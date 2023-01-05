using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
     public Rigidbody rb;
    Score score;

     public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    { score=FindObjectOfType<Score>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        if(transform.position.z<-6)
        {
            Destroy(gameObject);
            score.scoreBoard++;

        }
    }
}
