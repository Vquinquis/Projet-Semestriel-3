using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stay : MonoBehaviour
{
    private static Stay instance;

    private void Awake()
    {
        if (instance == null)
        {
            //instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        print(instance);
    }
}
