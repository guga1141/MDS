using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadImage : MonoBehaviour
{
    [SerializeField]
    private Texture2D[] images;
    private Texture2D image;

    [SerializeField]
    private GameObject wallObject;

    [SerializeField]
    private GameObject groundObject;
    // Start is called before the first frame update
    private void Start()
    {
        image = images[Random.Range(0, images.Length)];
        Color[] pix = image.GetPixels();

        int worldX = image.width;
        int worldZ = image.height;

        Vector3[] spawnPositions = new Vector3[pix.Length];
        Vector3 startingSpawnPosition = new Vector3(-Mathf.Round(worldX / 2), 0, -Mathf.Round(worldZ / 2));
        Vector3 currentSpawnPos = startingSpawnPosition;

        int counter = 0;

        for (int z = 0; z < worldZ; z++)
        {
            for(int x = 0; x < worldX; x++)
            {
                spawnPositions[counter] = currentSpawnPos;
                counter++;
                currentSpawnPos.x++;
            }
            currentSpawnPos.x = startingSpawnPosition.x;
            currentSpawnPos.z++;
        }
        counter = 0;

        foreach(Vector3 pos in spawnPositions)
        {
            Color c = pix[counter];
            if (c.Equals(Color.white))
            {
                Instantiate(wallObject, pos, Quaternion.identity);
            }
            else if (c.Equals(Color.black))
            {
                Instantiate(groundObject, pos, Quaternion.identity);
            }
            counter++;
        }
    }   
}
