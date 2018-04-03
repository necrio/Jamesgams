using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambooGrid : MonoBehaviour {

	public isBamboo[] isBamboo;

	int[,] bamboo;
    [SerializeField]
	int gridSizeX = 16;
    [SerializeField]
	int gridSizeY = 7;

	void Start () {
		bamboo = new int[gridSizeX, gridSizeY];

		for (int X = 0; X <= gridSizeX; X++) {
			for (int Y = 0; Y <= gridSizeY; Y++) {
				bamboo [X, Y] = 0;

			}
        }
	}
    void generateMap()
	{
		for (int X = 0; X <= gridSizeX; X++)
		{
			for (int Y = 0; Y <= gridSizeY; Y++)
			{

			}
		}
	}

}
