using UnityEngine;
using UnityEngine.UI;

public class IdCard : MonoBehaviour
{
    [SerializeField]
    private Text idText;

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

    private Name[] frenchNames = new Name[]
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

    private Name[] englishNames = new Name[]
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

    private Name[] japaneseName = new Name[]
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

    private string[] englishFilms = new string[]
    {
        "Star Wars Ep III",
        "The Lorax",
        "The Matrix",
        "Bambi",
        "Miracle on 34th st",
        "Planet of the Apes",
        "Finding Nemo",
        "Little Miss Sunshine",
        "American Pie",
        "Big"
    };

    private string[] frenchFilms = new string[]
    {
        "La Grande Vadrouille",
        "La Cité de la Peur",
        "Les Visiteurs",
        "Le Père Noël est une Ordure",
        "L'Auberge Espagnol",
        "Les Tontons Flingeurs",
        "Intouchables",
        "Oss 117",
        "Léon",
        "L'aile ou la Cuisse"
    };

    private string[] japaneseAnimes = new string[]
    {
        "Gochuumon wa Usagi Desu ka?",
        "Chuunibyou Demo Koi ga Shitai!",
        "Sono Hanabira ni Kuchizuke wo: Anata to Koibito Tsunagi",
        "Kore wa Zombie Desu ka?",
        "Koe de Oshigoto! The Animation",
        "Steins;Gate",
        "Ano Hi Mita Hana no Namae wo Bokutachi wa Mada Shiranai",
        "Plastic Memories",
        "No Game No Life",
        "Corpse Party: Tortured Souls - Bougyakusareta Tamashii no Jukyou"
    };

    private string[] likes = new string[]
    {
        "His dad",
        "C++",
        "Feet",
        "Macron",
        "Life",
        "Drugs",
        "Santa Claus",
        "Baguette",
        "Yahoo mail",
        "Darkness"
    };

    public void Start()
    {
        Name name = englishNames[Random.Range(0, englishNames.Length - 1)];
        string movie = englishFilms[Random.Range(0, englishFilms.Length - 1)];
        string like = likes[Random.Range(0, likes.Length)];
        string dislike;
        do
        {
            dislike = likes[Random.Range(0, likes.Length)];
        } while (like == dislike);
        idText.text = "<b>Name:</b> " + name.FirstName + System.Environment.NewLine
            + "<b>Sexe:</b> " + ((name.IsBoy) ? ("Boy") : ("Girl")) + System.Environment.NewLine
            + "<b>Age:</b> " + Random.Range(8, 15) + System.Environment.NewLine
            + "<b>Like:</b> " + like + System.Environment.NewLine
            + "<b>Dislike:</b> " + dislike + System.Environment.NewLine
            + "<b>Favorite Movie:</b> " + movie;
    }
}
