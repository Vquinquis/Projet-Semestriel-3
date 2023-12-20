using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop_Menu : MonoBehaviour, ITouchable
{
    public GameObject image;
    public bool active = false;

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
}
