using UnityEngine;

[CreateAssetMenu(fileName = "Nueva Carta", menuName = "Warlords/Creature Card", order = 0)]
public class CardAsset : ScriptableObject {

    public string cardName = "";
    [Space]
    [Range(1,10)]public int level = 1;
    public Rune rune = Rune.Iron;
    [Space]
    public int attack = 1;
    public int health = 1;
    public bool isWarlord;
    [Header("Efectos")]
    public string effectName ="";
    public int effectValue;
    [Space]
    [TextArea(2,5)]
    public string description = "";

    


}
