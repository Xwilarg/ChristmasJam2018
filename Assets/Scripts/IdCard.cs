using UnityEngine;
using UnityEngine.UI;
using static NaughtyList;
using static Utils;

public class IdCard : MonoBehaviour
{
    [SerializeField]
    private Text idText;

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
        FullName full;
        if (Random.Range(0, 11) == 0)
        {
            NaughtyList list = GameObject.FindGameObjectWithTag("NaughtyList").GetComponent<NaughtyList>();
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<SpawnGift>().IncreaseScore(-999);
            full = list.GetNaugthyKid();
        }
        else
            full = GetFullName();
        Name name = full.FirstName;
        string lastName = full.LastName;
        WorldSelection ws = null;
        GameObject go = GameObject.FindGameObjectWithTag("WorldSelection");
        if (go != null)
            ws = go.GetComponent<WorldSelection>();
        WorldSelection.Country country = WorldSelection.Country.USA;
        if (ws != null)
            country = ws.country;
        string movie;
        if (country == WorldSelection.Country.France)
            movie = frenchFilms[Random.Range(0, frenchFilms.Length)];
        else if (country == WorldSelection.Country.Japan)
            movie = japaneseAnimes[Random.Range(0, japaneseAnimes.Length)];
        else
            movie = englishFilms[Random.Range(0, englishFilms.Length)];
        string like = likes[Random.Range(0, likes.Length)];
        string dislike;
        do
        {
            dislike = likes[Random.Range(0, likes.Length)];
        } while (like == dislike);
        idText.text = "<b>First Name:</b> " + name.FirstName + System.Environment.NewLine
            + "<b>Last Name:</b> " + lastName + System.Environment.NewLine
            + "<b>Gender:</b> " + ((name.IsBoy) ? ("Boy") : ("Girl")) + System.Environment.NewLine
            + "<b>Age:</b> " + Random.Range(8, 16) + System.Environment.NewLine
            + "<b>Like:</b> " + like + System.Environment.NewLine
            + "<b>Dislike:</b> " + dislike + System.Environment.NewLine
            + "<b>Favorite Movie:</b> " + movie;
    }
}
