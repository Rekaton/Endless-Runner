using UnityEditor.Rendering;
using UnityEngine;

public class Backgroundlooper : MonoBehaviour
{
    public int speed;
    public Renderer backgroundrenderer;
    void Update()
    {
        backgroundrenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
} 
