using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambooGrid : MonoBehaviour {

	public IsBamboo[] gridType;

	int[,] bamboo;
    [SerializeField]
	int gridSizeX = 16;
    [SerializeField]
	int gridSizeY = 7;

	void Start () {
		bamboo = new int[gridSizeX, gridSizeY];

		for (int X = 0; X < gridSizeX; X++) {
			for (int Y = 0; Y < gridSizeY; Y++) {
				bamboo [X, Y] = 0;

			}
        }

		bamboo[1, 2]=1;
		bamboo[2,3]=1;
		bamboo[3,4]=1;
		bamboo[4,5]=1;
		bamboo[5,6]=1;
		bamboo[6,6]=1;
		bamboo[7,6]=1;

		generateMap();
	}
    void generateMap()
	{
		for (int X = 0; X < gridSizeX; X++)
		{
			for (int Y = 0; Y < gridSizeY; Y++)
			{
				Instantiate(gridType[bamboo[X, Y]], new Vector3(X, Y, 0), Quaternion.identity);
				Debug.Log("debug");

			}
		}
	}

}
