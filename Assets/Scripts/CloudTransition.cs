using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTransition : MonoBehaviour
{

    [SerializeField] private Material myMaterial;
    [SerializeField] private Renderer myModel;
    private float alpha = 0f;

    private void Start()
    {
        Color color = myMaterial.color;
        color.a = 0f / 255f;
        myMaterial.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        alpha++;
        Color color = myMaterial.color;
        color.a = alpha +0f / 255f;
        Debug.Log(alpha);
    }
}
