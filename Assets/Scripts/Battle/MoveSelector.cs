using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveSelector : MonoBehaviour
{
    [SerializeField] GameObject moveSelector;

    [SerializeField] List<TMP_Text> moveTexts;

    [SerializeField] List<TMP_Text> ppTexts;

    [SerializeField] List<Image> moveTypes;

    public void EnableMoveSelector(bool enabled)
    {
        moveSelector.SetActive(enabled);
    }

}
