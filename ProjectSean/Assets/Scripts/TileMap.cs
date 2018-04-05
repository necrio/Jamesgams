using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
	public GameObject UnitSelect;
    public TileType[] tileTypes;
	public float bambooHeight;
    int[,] tiles;
    int mapSizeX = 16;
    int mapSizeZ = 7;
	Vector3 gridPosition;

    void Start ()
	{
		GenerateMap();
        GeneratePrefabs();

	}	

	void GenerateMap()
	{
		gridPosition = transform.localPosition;

		tiles = new int[mapSizeX, mapSizeZ];
		for (int x = 0; x < mapSizeX; x++)
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
		tiles[6, 2] = 1;
		tiles[6, 6] = 1;
		tiles[7, 2] = 1;
		tiles[8, 4] = 1;
		tiles[8, 5] = 1;
		tiles[9, 0] = 1;
		tiles[9, 2] = 1;
		tiles[10, 6] = 1;
		tiles[11, 0] = 1;
		tiles[11, 3] = 1;
		tiles[11, 6] = 1;
		tiles[13, 4] = 1;
		tiles[14, 6] = 1;
		tiles[15, 6] = 1;
		for (int x = 12; x < 16; x++)
		{
			for (int z = 0; z < 4; z++)
			{
				tiles[x, z] = 1;
			}
		}
	}

    void GeneratePrefabs()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int z = 0; z < mapSizeZ; z++)
            {
                TileType tt = tileTypes[tiles[x, z]];
                GameObject go =(GameObject)Instantiate(tt.tilePrefab, new Vector3(gridPosition.x+x, bambooHeight, gridPosition.z+z), Quaternion.identity);
				//DudeMoveTo ct = go.GetComponent<DudeMoveTo>();
				//ct.tileX = x;
				//ct.tileZ = z;
				//ct.map = this;

            }

        }

    }

	public void MoveDudeTo(int x, int z)
	{
		UnitSelect.transform.position = new Vector3(x, 0, z);

	}

}
