using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryList : MonoBehaviour
{
    [SerializeField]
    private Text actionList;

    private const int listSizeMin = 5;
    private const int listSizeMax = 10;

    private struct Action
    {
        public Action(string description, Rating score)
        {
            Description = description;
            Score = score;
        }

        public string Description;
        public Rating Score;
    }

    private enum Rating
    {
        VeryBad = -2,
        Bad,
        Neutral,
        Good,
        VeryGood
    }

    private readonly Action[] actions = new Action[]
    {
        new Action("Cheated on psychology exam", Rating.Bad),
        new Action("Broke an antic vase", Rating.Bad),
        new Action("Attended furry convention", Rating.Neutral),
        new Action("Still use Team Speak in 2018", Rating.Neutral),
        new Action("Drown a fish", Rating.Bad),
        new Action("Didn't follow the theme in a game jam", Rating.Bad),
        new Action("Gave money at the church", Rating.Good),
        new Action("Won waterpolo contest", Rating.Neutral),
        new Action("Masturbated in bed", Rating.Neutral),
        new Action("Bought WinRar", Rating.Good),
        new Action("Tried to summon the devil", Rating.VeryBad),
        new Action("Stole his mother's underwear", Rating.Bad),
        new Action("Helped a deaf blinded homeless guy", Rating.VeryGood)
    };

    private void Start()
    {
        List<int> wishesId = Utils.GetItems(actions.Length, listSizeMin, listSizeMax);
        string finalText = "";
        foreach (int i in wishesId)
            finalText += "dd/MM/yyyy: " + actions[i].Description + System.Environment.NewLine;
        actionList.text = finalText;
    }
}
