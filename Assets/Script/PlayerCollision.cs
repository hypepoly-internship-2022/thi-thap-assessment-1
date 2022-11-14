
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerCollision movement;
  

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
