using UnityEngine;

public class FollowScript : MonoBehaviour
{

    public Transform player; // reference to player ke position
  public Vector3 offset;
    // Update is called once per frame
    void Update()
    { //transform refers to the transform of the game object that this script is attached to
        transform.position = player.position + offset;
    }
}
