using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Gift : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dest"))
        {
            Text text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            GiftObject gift = GetComponent<GiftObject>();
            text.text = "Score: " + (int.Parse(text.text.Split(' ').Last()) + (gift.Score * 100f)).ToString();
            Destroy(gameObject);
        }
    }
}
