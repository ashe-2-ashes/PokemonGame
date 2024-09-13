using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionSelector : MonoBehaviour
{
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
   
    public void EnableActionSelector(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    public void whenFightClicked()
    {
        if (moveSelector.activeInHierarchy == true)
        {
            moveSelector.SetActive(false);
            actionSelector.SetActive(true);
        }
        else
        {
            moveSelector.SetActive(true);
            actionSelector.SetActive(false);
        }
    }
}
