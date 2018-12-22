using UnityEngine;

public class GiftObject : MonoBehaviour
{
    public enum GObject
    {
        Coal = -1,
        SegaNeptune,
        PlasticDuck,
        SubmachineGun,
        WhitePencil,
        LittleSister,
        VeryBigCat,
        Friends,
        HentaiHeaven,
        AppleJuice,
        HumanSizeCockroach,
        LesMiserables,
        YellowVest,
        Dakimakura
    }

    public GObject Obj;

    [HideInInspector]
    public int Score;
}
