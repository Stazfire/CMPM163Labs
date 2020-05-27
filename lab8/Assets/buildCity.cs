using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 10;
    public int mapHeight = 10;
    public int freeSpace = 3;
    Quaternion randomRotation;

    void Start()
    {
        float seed = Random.Range(0, 100);
        for (int h = -mapHeight; h < mapHeight; h++)
        {
            for (int w = -mapWidth; w < mapWidth; w++)
            {
                int rotaryValue = Random.Range(0, 5);
                if (rotaryValue == 1)
                {
                    randomRotation = Quaternion.Euler(0, 0, 0);
                }
                if (rotaryValue == 2)
                {
                    randomRotation = Quaternion.Euler(0, 90, 0);
                }
                if (rotaryValue == 3)
                {
                    randomRotation = Quaternion.Euler(0, 180, 0);
                }
                if (rotaryValue == 4)
                {
                    randomRotation = Quaternion.Euler(0, 270, 0);
                }
                int result = (int)(Mathf.PerlinNoise(w / 10.0f + seed, h / 10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * freeSpace, 0, h * freeSpace);
                if (result < 3)
                {
                    Instantiate(buildings[0], pos, randomRotation);
                }
                else if (result < 4)
                {
                    Instantiate(buildings[1], pos, randomRotation);
                }
                else if (result < 5)
                {
                    Instantiate(buildings[2], pos, randomRotation);
                }
                else if (result < 6)
                {
                    Instantiate(buildings[3], pos, randomRotation);
                }
                else if (result < 7)
                {
                    Instantiate(buildings[4], pos, randomRotation);
                }
                else if (result < 8)
                {
                    Instantiate(buildings[5], pos, randomRotation);
                }
                else if (result < 9)
                {
                    Instantiate(buildings[6], pos, randomRotation);
                }
                else if (result < 10)
                {
                    Instantiate(buildings[7], pos, randomRotation);
                }
                else if (result < 11)
                {
                    Instantiate(buildings[8], pos, randomRotation);
                }
            }
        }
    }
}