using UnityEngine;

public class Collision : MonoBehaviour
{
    
public Playermovement movement;

void OnCollisionEnter (UnityEngine.Collision collisionInfo)
{
if (collisionInfo.gameObject.tag == "Obstacle") 
{
     movement.enabled = false;
     FindObjectOfType<GameManager>().EndGame();
}
}
    
}
