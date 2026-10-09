using UnityEngine;

public class ObstaclesSquare : ObstaclesBar
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float extraSpeed = 2f;
    private void Start()
    {
        if (Random.value < 0.3f)
            extraSpeed = 10f;
    }
    protected override void Move()
    {
        base.Move();
        transform.position += Vector3.down * extraSpeed * Time.deltaTime;
    }
    //Xoa Star va Update cua class con vi Unity se xu ly Update cua con thay vi cha ma con Update
    // == rong nen ->>> loi;
}
