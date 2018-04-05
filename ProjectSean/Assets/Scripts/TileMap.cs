using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{

    public TileType[] tileTypes;
    int[,] tiles;
    int mapSizeX = 16;
    int mapSizeZ = 7;
	Vector3 x;
	Vector3 z;

    void Start ()
	{
		x = transform.localPosition;
		z = transform.localPosition;

        tiles = new int[mapSizeX, mapSizeZ];
        for (int x=0; x < mapSizeX; x++)
        {
            for (int z = 0; z < mapSizeZ; z++)
            {
                tiles[x, z] = 0;

            }

        }
        tiles[0, 0] = 1;
        tiles[0, 1] = 1;
        tiles[2, 2] = 1;
        tiles[2, 5] = 1;
        tiles[2, 6] = 1;
        tiles[3, 0] = 1;
        tiles[3, 6] = 1;
        tiles[4, 0] = 1;
        tiles[4, 1] = 1;
        tiles[4, 3] = 1;
        tiles[5, 0] = 1;
        tiles[5, 4] = 1;
        tiles[5, 6] = 1;

        GenerateMap();

	}	

    void GenerateMap()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int z = 0; z < mapSizeZ; z++)
            {
                TileType tt = tileTypes[tiles[x, z]];
                Instantiate(tt.tilePrefab, new Vector3(x, 0, z), Quaternion.identity);

            }

        }

    }

}
