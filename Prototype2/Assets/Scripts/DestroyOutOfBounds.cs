using TreeEditor;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool exceedTopBound = transform.position.z > topBound;
        bool exceedLowerBound = transform.position.z < lowerBound;

        if (exceedLowerBound)
        {
            Debug.Log("Game over");
        }

        if (exceedLowerBound || exceedTopBound)
        {
            Destroy(gameObject);
        }
    }
}
