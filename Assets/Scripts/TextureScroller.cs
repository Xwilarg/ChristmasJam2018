using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float flowRate;
    private Vector2 flowVector;

    private MeshRenderer myMesh;    

    // Start is called before the first frame update
    void Start()
    {
        myMesh = transform.GetComponent<MeshRenderer>();
        flowVector = new Vector2(flowRate, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myMesh.material.mainTextureOffset += flowVector * Time.deltaTime;           
    }
}
