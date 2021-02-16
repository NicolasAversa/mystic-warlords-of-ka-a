using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isLocal;
    public int health = 30;

    public Deck deck {get;set;}
    public List<CardLogic> cardsInHand = new List<CardLogic>();
    public List<CardLogic> cardsInFront = new List<CardLogic>();
    public Transform front;
    public Transform hand;

    private void Start() {
        deck = GetComponent<Deck>();

        foreach(Transform card in front)
        {
            
            CardLogic logic = card.GetComponent<CardLogic>();

            if(logic == null) break;

            cardsInFront.Add(logic);
        }


    }

    public void HandleDiscardPhase()
    {
        CheckElegibleCards();
    }

    public void FillHand()
    {
        var numberofCardsInHand = cardsInHand.Count;

        for(int i=numberofCardsInHand; i<5; i++)
        {
            var newCard = deck.DrawCard();

            // Instanciar las cartas
            CardLogic cardLogic = Instantiate(GameManager.instance.handCardPrefab, hand).GetComponent<CardLogic>();
            
            cardsInHand.Add(cardLogic);
        }
    }

    public void CheckElegibleCards(){
        CardAsset otherCard = GameManager.instance.discardPile.GetTopCardAsset();

        foreach(CardLogic myCardLogic in cardsInHand)
        {
            CardAsset myCard = myCardLogic.cardAsset;
            if(IsDiscardPhaseWinner(myCard, otherCard))
            {
                myCardLogic.ActivateForDiscard();
            }
        }
    }

    public bool IsDiscardPhaseWinner(CardAsset myCard, CardAsset otherCard){
        var runeA = (int)myCard.rune;
        var runeB = (int)otherCard.rune;

        var levelWin = false;
        var runeWin = false;

        // victoria por nivel
        if(myCard.level > otherCard.level)
            levelWin = true;

        // victoria por runa
        if(runeA == 1 && runeB == 5)
            runeWin = true;
        else
        if(runeA == runeB+1)
            runeWin = true;  

        // Era mejor?
        if(runeWin || levelWin)
            return true;
        else
            return false;


    }

    public void DiscardCard(CardAsset cardAsset)
    {

    }

}
