using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region Sigleton

    public static GameManager instance;
    private void Awake() {
        if(instance == null)
            instance = this;    
        else{
            Destroy(this.gameObject);
        }
    }

    #endregion Singleton

    // VARIABLES
    public Player localPlayer;
    public Player enemyPlayer;
    public GameObject handCardPrefab;
    public GameObject playCardPrefab;
    [Space]
    public DiscardPile discardPile;
    public Transform discardTarget;

    // EVENTOS
    public UnityEvent drawPhase;
    public UnityEvent discardPhase;
    public UnityEvent combatPhase;
    public UnityEvent endPhase;


    private void Start() {
        OnGameStart();
    }

    void OnGameStart(){
        drawPhase.Invoke();
        discardPhase.Invoke();
    }

    // TODO: BORRAR
    public void FightTest()
    {
        CardLogic cardA = localPlayer.cardsInFront[0];
        CardLogic cardB = enemyPlayer.cardsInFront[0];

        cardA.health -= cardB.attack;
        cardB.health -= cardA.attack;

        if(cardA.health <= 0) 
            cardA.Die();

        if(cardB.health <= 0)
            cardB.Die();
    }

    // TODO: BORRAR
    public void DiscardTest()
    {
        CardLogic cardA = localPlayer.cardsInFront[0];
        CardLogic cardB = enemyPlayer.cardsInFront[0];

        var nivelA = cardA.level;
        var nivelB = cardB.level;
        int runeA = (int)cardA.rune;
        int runeB = (int)cardB.rune;
        var win = false;
        bool levelWin = false;
        bool runeWin = false;
        

        // TODO: comparar con turno actual

        // victoria por nivel
        if(cardA.level > cardB.level)
            levelWin = true;

        // victoria por runa
        if(runeA == 1 && runeB == 5)
            runeWin = true;
        else
        if(cardA.rune == cardB.rune+1)
            runeWin = true;  


        if(runeWin || levelWin)
            cardB.Die();


        bool[] boolVariables = new bool[2];

        if (boolVariables.Length == 0) return;

        var allTrue = true;

        for (var i = 0; i < boolVariables.Length; i++) 
        {
            if (!boolVariables[i])
            {
                allTrue = false;
                break;
            }
        }



    }
}
