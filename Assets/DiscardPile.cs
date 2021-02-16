using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    public CardAsset GetTopCardAsset()
    {
        if(cards.Count < 1)
            return null;

        //cards.FindLast(CardAsset);
        CardAsset assetToReturn = cards[cards.Count-1].GetComponent<CardLogic>().cardAsset;

        return assetToReturn;
    }
}
