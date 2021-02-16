using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<CardAsset> cards = new List<CardAsset>();

    public void Shuffle()
    {

    }

    public CardAsset DrawCard()
    {
        CardAsset cardToReturn = cards[0];

        cards.RemoveAt(0);

        return cardToReturn;
    }
}
