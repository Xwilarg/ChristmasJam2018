using UnityEngine;

public class ScrollHouse : MonoBehaviour
{
    private const float speed = 2f;

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
