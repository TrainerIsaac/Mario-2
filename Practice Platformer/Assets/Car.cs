using UnityEngine;

public class Car : MonoBehaviour
{
    protected virtual void Right()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
    protected virtual void Left()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Right();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Left();
        }
    }

}