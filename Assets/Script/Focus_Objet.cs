using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Focus_Objet : MonoBehaviour, ITouchable
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
    public ObjetManager manager;

    private void Start()
    {
        manager = FindObjectOfType<ObjetManager>();
        level = VariableLibrary.instance.GetLevel(ID);
        UpdateInfos();
        moneyManager = FindObjectOfType<Money>();
    }

    public void ChangeLevel(int newLevel)
    {
        level = Mathf.Clamp(newLevel, 0, 2);
        VariableLibrary.instance.RegisterLevel(ID, level);
        UpdateInfos();
    }
    public void Upgrade()
    {
        if (Money.score >= price)
        {
            Money.score -= price;
            ChangeLevel(level + 1);

        }
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
        manager.currentSelectedStand = this;
        manager.DisplayUI();

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

}
