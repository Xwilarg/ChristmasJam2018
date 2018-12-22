using System.Collections.Generic;
using System.Linq;
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
        return (CapitalizeFirst(name));
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
        return (CapitalizeFirst(name));
    }

    public struct Name
    {
        public Name(string firstName, bool isBoy)
        {
            FirstName = firstName;
            IsBoy = isBoy;
        }

        public string FirstName;
        public bool IsBoy;
    }

    public static string CapitalizeFirst(string str)
    {
        return (char.ToUpper(str[0]) + string.Join("", str.Skip(1)));
    }

    public static readonly Name[] frenchNames = new Name[]
    {
        new Name("Carole", false),
        new Name("Jean", true),
        new Name("Léo", true),
        new Name("Louis", true),
        new Name("Nathan", true),
        new Name("Henri", true),
        new Name("Thierry", true),
        new Name("Charles", true),
        new Name("Cloé", false),
        new Name("Jeanne", false),
        new Name("Jean-Pierre", false),
        new Name("Suzette", true)
    };

    public static readonly Name[] englishNames = new Name[]
    {
        new Name("Isabella", false),
        new Name("Noah", true),
        new Name("Ethan", true),
        new Name("Shirley", false),
        new Name("Ricky", true),
        new Name("Emma", false),
        new Name("Mike", true),
        new Name("Kate", false)
    };

    public static readonly Name[] japaneseName = new Name[]
    {
        new Name("Hanako", false),
        new Name("Yamato", true),
        new Name("Haruna", false),
        new Name("Tsukiko", false),
        new Name("Rikka", false),
        new Name("Hibiki", false),
        new Name("Konagi", false),
        new Name("Haruto", true),
        new Name("Reo", true),
        new Name("Rin", false)
    };
}
