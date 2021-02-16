using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    CardLogic logic;
    [SerializeField]Image glow;
    [SerializeField]Image art;
    [SerializeField]Image rune;
    [Space]
    [SerializeField]Text level;
    [SerializeField]Text health;
    [SerializeField]Text attack;


    void Start()
    {
        logic = GetComponent<CardLogic>();
    }


}
