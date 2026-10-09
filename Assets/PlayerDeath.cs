using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponentInParent<ObstaclesBar>() == null) return;
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }
}
