using UnityEngine;

public class DragGift : MonoBehaviour
{
    private bool followMouse;

    private void Start()
    {
        followMouse = false;
    }

    private void Update()
    {
        if (followMouse)
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            newPos.z = 0f;
            transform.position = newPos;
        }
    }

    private void OnMouseDown()
    {
        followMouse = true;
    }

    private void OnMouseUp()
    {
        followMouse = false;
    }
}
