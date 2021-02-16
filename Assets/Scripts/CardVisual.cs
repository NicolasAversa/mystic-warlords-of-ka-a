using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    CardLogic logic;
    [SerializeField]Image glow;
    [SerializeField]Image art;
    [SerializeField]Image rune;
    [SerializeField]Color singleBeatColor = Color.green;
    [SerializeField]Color doubleBeatColor = Color.blue;
    [Space]
    [SerializeField]Text level;
    [SerializeField]Text health;
    [SerializeField]Text attack;


    void Start()
    {
        logic = GetComponent<CardLogic>();
    }

    public void UpdateVisual(CardAsset asset)
    {
        level.text = asset.level.ToString();
        health.text = asset.health.ToString();
        attack.text = asset.attack.ToString();


    }

    public void Glow(){
        glow.color = singleBeatColor;
    }
}
