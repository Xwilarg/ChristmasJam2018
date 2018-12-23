using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schoolboard : MonoBehaviour
{
    [SerializeField]
    private Text gradeList;

    private struct SchoolGrade
    {
        public SchoolGrade(string description, int scoreMin, int scoreMax)
        {
            Description = description;
            ScoreMin = scoreMin;
            ScoreMax = scoreMax;
        }

        public string Description;
        public int ScoreMin, ScoreMax;
    }

    private readonly SchoolGrade[] grades = new SchoolGrade[]
    {
        new SchoolGrade("Meh", 9, 11),
        new SchoolGrade("Definitly my best student", 19, 20),
        new SchoolGrade("Didn't come to any lesson", 0, 0),
        new SchoolGrade("Have cool shoes", 12, 16),
        new SchoolGrade("I wish I was a butterfly", 8, 13),
        new SchoolGrade("lol k", 4, 8),
        new SchoolGrade("See you next year", 2, 5),
        new SchoolGrade("Could have done better", 17, 19),
        new SchoolGrade("Good trimester", 15, 18),
        new SchoolGrade("You could have better marks if you were trying", 10, 13),
    };

    private readonly string[] subjects = new string[]
    {
            "Maths",
            "Literature",
            "Philosophy",
            "History",
            "Geography",
            "Chemistry",
            "Physics"
    };

    private void Start()
    {
        ResetContent();
    }

    public void ResetContent()
    {
        List<int> wishesId = Utils.GetItems(grades.Length, subjects.Length, subjects.Length);

        string finalText = "";
        int y = 0;
        SpawnGift manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SpawnGift>();
        int sum = 0;
        foreach (int i in wishesId)
        {
            int mark = Random.Range(grades[i].ScoreMin, grades[i].ScoreMax);
            sum += mark;
            finalText += "<b>" + subjects[y++] + ":</b>" + System.Environment.NewLine + grades[i].Description + " ; " + mark + " / 20" + System.Environment.NewLine + System.Environment.NewLine;
        }
        manager.IncreaseScore(((float)sum / wishesId.Count) - 10f);
        gradeList.text = finalText;
    }
}
