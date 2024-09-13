using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] PokemonBase base_;
    [SerializeField] int level;
    [SerializeField] bool isPlayerPokemon;

    public Pokemon Pokemon {  get; set; }

    public void Setup()
    {
        Pokemon = new Pokemon(base_, level);
        if (isPlayerPokemon)
            GetComponent<Image>().sprite = Pokemon.Base.BackSprite;
        else
            GetComponent<Image>().sprite = Pokemon.Base.FrontSprite;
    }
}
