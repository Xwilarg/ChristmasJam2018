using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Wishlist : MonoBehaviour
{
    [SerializeField]
    private Text wishList;

    private const int listSizeMin = 3;
    private const int listSizeMax = 10;

    public List<int> wishesId { private set; get; }

    private readonly string[] wishes = new string[]
    {
        "Sega Neptune",
        "Mommy's Plastic Duck",
        "Submachine gun",
        "White pencil",
        "A little sister",
        "A very big cat",
        "Friends",
        "Hentai Heaven to be back",
        "Apple juice",
        "A human size cockroach",
        "Les Misérables complete edition",
        "Yellow vest",
        "Dakimakura"
    };

    private void Start()
    {
        wishesId = Utils.GetItems(wishes.Length, listSizeMin, listSizeMax);
        string finalText = "";
        int y = 1;
        foreach (int i in wishesId)
            finalText += (y++) + ". " + wishes[i] + System.Environment.NewLine;
        wishList.text = finalText;
    }
}
