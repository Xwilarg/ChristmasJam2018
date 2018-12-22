using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static List<int> GetItems(int itemCount, int nbMin, int nbMax)
    {
        List<int> wishesId = new List<int>();
        int nbWishes = Random.Range(nbMin, nbMax);
        for (int i = 0; i < nbWishes;)
        {
            int id = Random.Range(0, itemCount - 1);
            if (!wishesId.Contains(id))
            {
                wishesId.Add(id);
                i++;
            }
        }
        return (wishesId);
    }

    public static string GenerateEuropeanLastName()
    {
        char[] vowels = new char[]
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };
        char[] consonants = new char[]
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };
        string name = "";
        int nameLength = Random.Range(5, 8);
        bool vowel = false;
        for (int i = 0; i < nameLength; i++)
        {
            if (vowel)
                name += vowels[Random.Range(0, vowels.Length - 1)];
            else
                name += consonants[Random.Range(0, consonants.Length - 1)];
            vowel = !vowel;
        }
        return (name);
    }

    public static string GenerateJapaneseLastName()
    {
        string[] syllables = new string[]
        {
            "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "ga", "gi", "gu", "ge", "go",
            "sa", "shi", "su", "se", "so", "za", "chi", "tsu", "ze", "zo",
            "ta", "fu", "te", "to", "da", "de", "do", "ha", "hi", "hu", "he", "ho",
            "ba", "bi", "bu", "be", "bo", "pa", "pi", "pu", "pe", "po",
            "ra", "ri", "ru", "re", "ro", "ma", "mi", "mu", "me", "mo",
            "na", "ni", "nu", "ne", "no", "wa", "wu", "wo"
        };
        string name = "";
        int nameLength = Random.Range(2, 5);
        for (int i = 0; i < nameLength; i++)
            name += syllables[Random.Range(0, syllables.Length)];
        return (name);
    }
}
