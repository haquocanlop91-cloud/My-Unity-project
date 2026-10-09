using UnityEngine;
using UnityEngine.Rendering;

public class ObstaclesL : ObstaclesBar
{
    public float switchTime = 1f;
    float timer, xA, xB;
    bool canSwitch , AtB;
    public void StartSwitch(float A , float B)
    {
        xA = A;
        xB = B;
        canSwitch = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Move()
    {
        base.Move();
        if (!canSwitch) return;
        timer += Time.deltaTime;
        if(timer > switchTime)
        {
            timer = 0;
            AtB = !AtB;
            transform.position = new Vector3((AtB) ? xB : xA, transform.position.y, 0);
        }
    }
}
