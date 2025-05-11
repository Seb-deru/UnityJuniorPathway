using System.Runtime.CompilerServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private int rotationSpeed;
    private float rotationAngleX = 10.0f;
    private float rotationAngleY = 45f;

    private float currentAlpha = 0.4f;
    private float alphaCoefficient = 1.5f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        rotationSpeed = Random.Range(2, 16);

        InvokeRepeating("UpdateMaterialAlpha", 2f, 1f);
    }
    
    void Update()
    {
        transform.Rotate(rotationAngleX * Time.deltaTime * rotationSpeed, rotationAngleY * Time.deltaTime * rotationSpeed, 0.0f);
    }

    private void UpdateMaterialAlpha()
    {
        Material material = Renderer.material;
        Debug.Log("1." + currentAlpha);
        if(currentAlpha > 1)
        {
            alphaCoefficient = 0.8f;
        } 
        else if(currentAlpha < 0.2)
        {
            alphaCoefficient = 1.5f;
        }

        currentAlpha *= alphaCoefficient;
        Debug.Log("2." + currentAlpha);
        material.color = new Color(currentAlpha, 1.0f, 0.3f, 0.4f);
    }
}
