using System.Collections.Generic;
using System.Linq;
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
        new Action("Cheated on philosophy exam", Rating.Bad),
        new Action("Broke an antique vase", Rating.Bad),
        new Action("Attended furry convention", Rating.Neutral),
        new Action("Still use Team Speak in 2018", Rating.Neutral),
        new Action("Drown a fish", Rating.Bad),
        new Action("Didn't follow the theme in a game jam", Rating.Bad),
        new Action("Gave money at the church", Rating.Good),
        new Action("Won waterpolo contest", Rating.Neutral),
        new Action("Masturbated in bed", Rating.Neutral),
        new Action("Bought WinRar", Rating.Good),
        new Action("Tried to summon the devil", Rating.VeryBad),
        new Action("Stole mother's underwear", Rating.Bad),
        new Action("Helped a deaf blind homeless guy", Rating.VeryGood),
        new Action("Made a very bad pun", Rating.Neutral),
        new Action("Planted a tree", Rating.Good),
        new Action("Drank a Pepsi", Rating.Bad),
    };

    private void Start()
    {
        List<int> wishesId = Utils.GetItems(actions.Length, listSizeMin, listSizeMax);
        string finalText = "";
        SpawnGift manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SpawnGift>();
        List<System.DateTime> dts = new List<System.DateTime>();
        for (int i = 0; i < wishesId.Count; i++)
            dts.Add(new System.DateTime(2018, Random.Range(1, 13), Random.Range(1, 30)));
        foreach (int i in wishesId)
        {
            manager.IncreaseScore((int)actions[i].Score);
            System.DateTime dt = dts.Min();
            dts.Remove(dt);
            finalText += dt.ToString("dd/MM") + ": " + actions[i].Description + System.Environment.NewLine;
        }
        actionList.text = finalText;
    }
}
