using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
	//contains the dude prefab to be called to spawn
	public GameObject UnitSelect;
	//class that holds the 0 or 1 of whether bamboo is in the tile
    public TileType[] tileTypes;
	//the height of the bamboo the grid moves up to spawn on
	public float bambooHeight;
	//array grid the tiles are spawned into
    public int[,] tiles;
	//grid max size
    int mapSizeX = 16;
    int mapSizeZ = 7;
	//vector3 to make the grid spawn local to the island and move with it
	Vector3 gridPosition;

    void Start ()
	{
		//functions offloaded from start for neatness below
		GenerateMap();
        GeneratePrefabs();
		GenerateDude();
	}	
	//generates the array map and names all the values to zero
	void GenerateMap()
	{
		//gridposition is called to be used in the next function(class?) because I make messes
		gridPosition = transform.localPosition;
		//grid size finalised
		tiles = new int[mapSizeX, mapSizeZ];
		//for loop naming the grid spots by type
		for (int x = 0; x < mapSizeX; x++)
		{
			for (int z = 0; z < mapSizeZ; z++)
			{
				tiles[x, z] = 0;

			}

		}
		//messy test code ignore meeeeeeeeeeeeeeeeeee
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
	//generates the tiles into the array
    void GeneratePrefabs()
    {
		//same for loop but does more things
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int z = 0; z < mapSizeZ; z++)
            {
				//instantiates the tiles though they have no renderers just for the hitboxes.
                TileType tt = tileTypes[tiles[x, z]];
                GameObject go =(GameObject)Instantiate(tt.tilePrefab, new Vector3(gridPosition.x+x, bambooHeight, gridPosition.z+z), Quaternion.identity);
				//sets each tile with coordinate values that can be called
				TilePosition ct = go.GetComponent<TilePosition>();
				ct.tileX = x;
				ct.tileZ = z;
				ct.map = this;

            }

        }

    }
	//generates the dude and gives him life and a place in the bamboo
	public void GenerateDude()
	{
		GameObject gp = (GameObject)Instantiate(UnitSelect, new Vector3(gridPosition.x+7, bambooHeight, gridPosition.z+4), Quaternion.identity);
		DudeMoveTo mt = gp.GetComponent<DudeMoveTo>();
		mt.moveToX = 7;
		mt.moveToZ = 4;
		//this little thing calls the map back to this script so other scripts know what "map" is
		mt.map = this;
	}
	//the buggy one coincidentally also the one 90% edited together by me, see the dudemoveto script for more why does this not WORK
	public void DudeJump(int x, int z)
	{
		UnitSelect.transform.position = new Vector3(x, bambooHeight, z);
	}

}
