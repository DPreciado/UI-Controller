using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float ColorPower = 1f;
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        render.material.SetFloat("_ColorPower", ColorPower);
    }
}
