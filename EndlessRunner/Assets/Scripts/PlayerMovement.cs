
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // this is a reference to the rigidbody component rb
public float forwardForce = 2000f;
public float sidewaysForce = 500f;

 [SerializeField] Canvas gameOverCanvas;
 //input updates in update method, so if the method is slower then its possiblethat the code might miss some input 
 // for one off events dont take input in fixed update, for that take input in update method store in a top variable and then use that variable in the  fixed update


    // Update is called once per frame
    void FixedUpdate() //FixedUpdate for physics
    {

       // rb.AddForce(0,0,forwardForce * Time.deltaTime); // this will depend on the frame rate, therefore use Time.deltaTime, higher the  frame rate, lower this value will be to even out at different systems

       if(Input.GetKey("d"))
       {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }
       if(Input.GetKey("a")) // add support for alternate keys and different consoles
       {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
       }
if(rb.position.y< -1)
{Invoke("ShowMenu", 1);
    //FindObjectOfType<GameManager>().EndGame();
}
    }
      void ShowMenu(){
        gameOverCanvas.enabled = true;
  Time.timeScale = 0;
       }
}
