using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    static public int score;
    public TextMeshProUGUI scoreText;
    private float time = 0.0f;
    private float timeWait = 5.0f;
    static public int mult;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("000000");
        time += Time.deltaTime;

        if (time >= timeWait)
        {
            time = 0.0f;
            RiseScore(1*mult);
        }
    }

    public void RiseScore(int amount)
    {
        score += amount;
        
    }
}
