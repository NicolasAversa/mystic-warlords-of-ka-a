using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public CardAsset cardAsset;
    [SerializeField] CardVisual visual;
    
    public int health;
    public int attack;
    public int level;
    public Rune rune;
    

    void Start()
    {
        // TODO: BORRAR
        LoadCardInfo(cardAsset);
    }

    public void LoadCardInfo(CardAsset _cardAsset)
    {
        this.cardAsset = _cardAsset;

        gameObject.name = _cardAsset.cardName;

        health = _cardAsset.health;
        attack = _cardAsset.attack;
        level = _cardAsset.level;
        rune = _cardAsset.rune;

        visual.UpdateVisual(cardAsset);
    }

    public void ActivateForDiscard(){
        // Encender eventos de mouse

        // Brillar
        visual.Glow();
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
