using JetBrains.Annotations;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bar;
    public GameObject square;
    public GameObject L;
    public float[] Barlanes = { -2.1f, -1.3f, -0.4f, 0.4f, 1.3f, 2.1f };
    public float[] Squarelanes = { -2.25f, -1.15f, -0.65f, 0.65f, 1.15f, 2.25f };
    public float[] Llanes = { -3.3f, -2.3f, -1.63f, -0.58f, 0.1f, 1.1f };
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rool = Random.value;
        timer += Time.deltaTime;
        int x = Random.Range(0, Barlanes.Length);
        
        if (timer >= 0.3)
        {
            if (rool <= 0.33f)
            {
                if(x >= 1 && x <= 4)
                {
                    float Rotation = Random.value;
                    if(Rotation < 0.7f)
                    {
                        Instantiate(bar, new Vector3((x <= 2 && x >=1) ? -0.85f : 0.85f, 6f, 0), Quaternion.Euler(0, 0, 90), transform);
                        timer = 0;
                        return;
                    }
                }
                Instantiate(bar, new Vector3(Barlanes[x], 6f, 0), Quaternion.identity, transform);
                //Instantinate( GameObject can copy , vi trí , rotation (Quaternion.identity hoac Quaternion.Euler(0,0,90);
                
            }
            else if(rool > 0.33f && rool <= 0.66f)
            {
               
                GameObject l = Instantiate(L , new Vector3(Llanes[x] , 6f , 0), Quaternion.identity, transform);
                if(x >= 1 && x <= 4 && Random.value < 0.5f)
                {
                    int other = (x % 2 == 0) ? other = x - 1 : other = x + 1;
                    l.GetComponent<ObstaclesL>().StartSwitch(Llanes[x] , Llanes[other]);
                }
            }
            else
                Instantiate(square, new Vector3(Squarelanes[x], 6f, 0), Quaternion.identity);
            timer = 0;  
        }
    }
}
