using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    private Touch touch;
    private float speed=0.0005f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //Translation Camera
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {

                transform.position -= transform.right * touch.deltaPosition.x * speed;
                transform.position -= transform.up * touch.deltaPosition.y * speed;

            }
        }


    }

}
