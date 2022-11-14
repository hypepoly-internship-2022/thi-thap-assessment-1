
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerCollision movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }
        
    }
    
}
