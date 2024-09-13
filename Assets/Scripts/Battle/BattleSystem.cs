using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy}

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerPokemon;
    [SerializeField] BattleUnit opponentPokemon;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleHUD opponentHUD;
    [SerializeField] BattleDialogueBox dialogueBox;
    [SerializeField] ActionSelector actionSelector;
    [SerializeField] MoveSelector moveSelector;

    BattleState state;
    int currentAction;

    private void Start()
    {
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle()
    {
        playerPokemon.Setup();
        playerHUD.SetData(playerPokemon.Pokemon);
        opponentPokemon.Setup();
        opponentHUD.SetData(opponentPokemon.Pokemon);
       

        
        yield return dialogueBox.TypeDialogue($"A wild {opponentPokemon.Pokemon.Base.Name} appeared!");
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    void PlayerAction()
    {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogueBox.TypeDialogue($"What will {playerPokemon.Pokemon.Base.Name} do?"));
        //actionSelector.EnableActionSelector(false);
        //moveSelector.EnableMoveSelector(true);
    }

    //private void Update()
    //{
        //if (state == BattleState.PlayerAction)
        //{
            //HandleActionSelection();
        //}
    //}

    //void HandleActionSelection()
    //{
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
            //if (currentAction < 1)
                //++currentAction;
        //}
        //else if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
           // if (currentAction < 0)
                //--currentAction;
        //}
    }

