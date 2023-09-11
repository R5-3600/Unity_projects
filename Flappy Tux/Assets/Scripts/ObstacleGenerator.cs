using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject PipePrefab;
    public int generationRate = 100;

    private int timer;




    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if(timer >=generationRate)
        {
            timer = 0;
            GameObject newObstacle = Instantiate(PipePrefab, new Vector2(PipePrefab.transform.position.x, PipePrefab.transform.position.y + Random.Range(-2f, 2f)), PipePrefab.transform.rotation);
            Destroy(newObstacle, 10f);
        }
    }
}
