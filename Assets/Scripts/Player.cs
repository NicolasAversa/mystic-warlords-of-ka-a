using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isLocal;
    public int health = 30;

    public Deck deck {get;set;}
    public List<CardAsset> cardsInHand = new List<CardAsset>();
    public List<CardLogic> cardsInFront = new List<CardLogic>();
    public Transform front;

    private void Start() {
        deck = GetComponent<Deck>();

        FillHand();

        foreach(Transform card in front)
        {
            
            CardLogic logic = card.GetComponent<CardLogic>();

            if(logic == null) break;

            cardsInFront.Add(logic);
        }


    }

    public void FillHand()
    {
        var numberofCardsInHand = cardsInHand.Count;

        for(int i=numberofCardsInHand; i<5; i++)
        {
            var newCard = deck.DrawCard();
            cardsInHand.Add(newCard);
        }
    }

    public void DiscardCard(CardAsset cardAsset)
    {

    }

}
