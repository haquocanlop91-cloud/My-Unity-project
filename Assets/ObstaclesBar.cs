using UnityEngine;

public class ObstaclesBar : MonoBehaviour
{
    public float speed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //transform.position = new Vector3(transform.position.x,transform.position.y +* speed, 0);
    protected virtual void Move()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (transform.position.y < -6f) Destroy(gameObject);
    }
}
