using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Gift : MonoBehaviour
{
    public int score { set; get; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dest"))
        {
            Text text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            text.text = "Score: " + (int.Parse(text.text.Split(' ').Last()) + (score * 100f)).ToString();
        }
    }
}
