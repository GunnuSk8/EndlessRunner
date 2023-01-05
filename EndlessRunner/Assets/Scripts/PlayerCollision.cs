
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
public PlayerMovement movement;
 [SerializeField] Canvas gameOverCanvas;
 void Start(){
     gameOverCanvas.enabled = false;
 }
    void OnCollisionEnter(Collision collisionInfo){
        
       if(collisionInfo.collider.tag=="Obstacle")
       {
         
        Debug.Log("we hit an obstacle!!");

        movement.enabled = false;
Invoke("ShowMenu", 1);
        //FindObjectOfType<GameManager>().EndGame();
       } }

        public void ShowMenu(){
        gameOverCanvas.enabled = true;
  Time.timeScale = 0;
       }
}
