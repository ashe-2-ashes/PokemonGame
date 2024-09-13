using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] HPBar hpBar;
    [SerializeField] TMP_Text currentHPText;
    [SerializeField] TMP_Text maxHPText;

    public void SetData(Pokemon pokemon)
    {
        nameText.text = pokemon.Base.Name;
        levelText.text = pokemon.Level.ToString();
        hpBar.SetHP((float) pokemon.CurrentHP / pokemon.MaxHP);
        currentHPText.text = pokemon.CurrentHP.ToString();
        maxHPText.text = pokemon.MaxHP.ToString();

    }
}
