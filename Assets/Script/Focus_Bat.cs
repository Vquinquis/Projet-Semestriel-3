using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Focus_Bat : MonoBehaviour, ITouchable
{
    public string ID;
    public GameObject pivot;
    public int level;
    public int price;
    public int mult;
    public Money moneyManager;
    
    [TextArea]
    public List<string> descriptions;
    public List<GameObject> displayedArchitecture;
    public StandManager manager;

    private void Start()
    {
        manager= FindObjectOfType<StandManager>();
        level = VariableLibrary.instance.GetLevel(ID);
        UpdateInfos();
        moneyManager = FindObjectOfType<Money>();
    }

    public void ChangeLevel(int newLevel)
    {
        level = Mathf.Clamp(newLevel, 0, 2);
        VariableLibrary.instance.RegisterLevel(ID,level);
        UpdateInfos();
    }
    public void Upgrade()
    {
        if (Money.score >= price)
        {
            Money.score -= price;
            ChangeLevel(level + 1);
            Money.mult += mult;
            if (ID == "Alpha")
            {
                price = 200;
                mult = 30;
            }
            if (ID == "Beta")
            {
                price = 600;
                mult = 50;
            }
            if (ID == "Delta")
            {
                price = 1000;
                mult = 100;
            }
            if (ID == "Epsilon")
            {
                price = 2500;
                mult = 100;
            }

        }
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        manager.currentSelectedStand = this;
        manager.DisplayUI();

        pivot.transform.position = transform.position ;
        zoom(2);

    }

    

    private void UpdateInfos()
    {
        foreach (var da in displayedArchitecture)
        {
            da.SetActive(false);
        }
        displayedArchitecture[level].SetActive(true);
    }
    public void OnTouchedStay(Vector3 touchPosition)
    {
        return;
    }

    public void OnTouchedUp()
    {
        return;
    }


    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, 1, 8);
    }
}
