using Unity.InferenceEngine.Tokenization.Truncators;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float sideOffset = 0.45f;
    bool isLeft = true;
    public int speed = 3;
    float Vitri = -0.45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        // Thiết lập ban đầu
        transform.position = new Vector3(-sideOffset, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Vi tri be hon am thi dung ham upfate
            if (Vitri <= -2.1f) 
                return;

            if (isLeft == true) // Dang o ben trai 
            {
                Vitri += -0.8f; // Qua mot lan
                isLeft = false; // Chuyen qua ben phai cot kia
            }
            else
            {
                Vitri -= sideOffset * 2; // Dang o ben phai thi qua gap doi
                isLeft = true; // qua ben trai phia ben kia
            }
            transform.position = new Vector3(Vitri, transform.position.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Vitri >= 2.1f) 
                return;
            if (isLeft == false)
            {
                Vitri += 0.8f;
                isLeft = true;
            }
            else
            {
                Vitri += sideOffset * 2;
                isLeft = false;
            }
            transform.position = new Vector3(Vitri, transform.position.y, 0);
        }
        // De Tam o day cach viet ngan ngon :)))))
        /* public float[] positions = { -2.28f, -1.14f, -0.57f, 0.57f, 1.14f, 2.28f };
        int slot = 2;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && slot > 0) slot--;
            if (Input.GetKeyDown(KeyCode.RightArrow) && slot < positions.Length - 1) slot++;

            transform.position = new Vector3(positions[slot], transform.position.y, 0);
        }*/
    }
}
