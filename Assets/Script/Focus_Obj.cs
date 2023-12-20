using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus_Obj : MonoBehaviour,ITouchable
{

    public GameObject pivot;
    public Active active;
    public GameObject image;
    public int id;
    public Button buttonMana;
    public GameObject Ttonn;
    public GameObject Tetag;
    public GameObject Tarmo;
    public GameObject Ttabl;
    public GameObject Tfour;
    public GameObject Tetag2;
    public GameObject Tlit;
    public GameObject Tlamp;

    public void OnTouchedDown(Vector3 touchPosition)
    {
        
       
        }
    

    public void OnTouchedStay(Vector3 touchPosition)
    {
        return;
    }

    public void OnTouchedUp()
    {
        return;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, 1, 8);
    }
}
