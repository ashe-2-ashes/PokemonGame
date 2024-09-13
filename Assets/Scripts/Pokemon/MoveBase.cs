using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokémon/Create New Move")]

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;
    [SerializeField] MoveCategory category;
    [SerializeField] int pp;
    [SerializeField] int power;
    [SerializeField] int accuracy;

    public string Name 
    { 
        get { return name; } 
    }

    public string Description
    {
        get { return description; }
    }

    public PokemonType Type
    {
        get { return type; }
    }

    public MoveCategory Category
    {
        get { return category; }
    }

    public int PP
    {
        get { return pp; }
    }

    public int Power
    {
        get { return power; }
    }

    public int Accuracy
    {
        get { return accuracy; }
    }
}

public enum MoveCategory
{
   Special,
   Physical,
   Status,
}