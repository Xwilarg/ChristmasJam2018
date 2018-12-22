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
        new SchoolGrade("I wish he could care as much for my lesson that he do for the other classmates", 4, 8),
        new SchoolGrade("I wish I was a butterfly", 8, 13),
        new SchoolGrade("Not bad kid", 12, 14),
        new SchoolGrade("lol k", 4, 8),
        new SchoolGrade("Be more sneaky if you try to cheat during exams", 4, 8),
        new SchoolGrade("Have a terrible accent, I don't understand a thing at what you say", 5, 8),
        new SchoolGrade("See you next year", 2, 5)
    };

    private readonly string[] subjects = new string[]
        {
            "Maths",
            "Literature",
            "English",
            "Philosophy",
            "French",
            "History",
            "Geography",
            "Science"
        };

    private void Start()
    {
        List<int> wishesId = Utils.GetItems(grades.Length, subjects.Length, subjects.Length);
        
        string finalText = "";
        int y = 0;
        foreach (int i in wishesId)
            finalText += "<b>" + subjects[y++] + ":</b>" + System.Environment.NewLine + grades[i].Description + " ; " + (Random.Range(grades[i].ScoreMin, grades[i].ScoreMax)) + " / 20" + System.Environment.NewLine + System.Environment.NewLine;
        gradeList.text = finalText;
    }
}
