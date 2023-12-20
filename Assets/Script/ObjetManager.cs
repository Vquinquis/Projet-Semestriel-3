using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetManager : MonoBehaviour
{
    public Focus_Objet currentSelectedStand;
    public TextMeshProUGUI descriptionTmpro;
    public FolderUI folderUI;


    public void Upgrade()
    {
        currentSelectedStand.Upgrade();
        descriptionTmpro.text = currentSelectedStand.descriptions[currentSelectedStand.level];

    }

    public void DisplayUI()
    {
        folderUI.gameObject.SetActive(true);
        descriptionTmpro.text = currentSelectedStand.descriptions[currentSelectedStand.level];
    }

}
