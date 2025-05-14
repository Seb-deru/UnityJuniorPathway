using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject SpawnPrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        if (!playerController.gameOver)
        {
            Instantiate(SpawnPrefab, spawnPosition, SpawnPrefab.transform.rotation);
        }
    }
}
