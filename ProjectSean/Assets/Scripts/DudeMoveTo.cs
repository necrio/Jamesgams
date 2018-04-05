using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeMoveTo : MonoBehaviour
{
	//set up the variables but they probably don't work.
	bool keyUp = false;
	bool keyDown = false;
	bool keyLeft = false;
	bool keyRight = false;
	//well these ones do but also don't really
	public int moveToX;
	public int moveToZ;
	public TileMap map;

	void Start () {
		
	}
	
	void Update () {
		bool keyUp = Input.GetKey(KeyCode.W);
		bool keyDown = Input.GetKey(KeyCode.S);
		bool keyLeft = Input.GetKey(KeyCode.A);
		bool keyRight = Input.GetKey(KeyCode.D);
		//run the DudeMove script back in the TileSet with slightly different variables input into it but it REALLY doesn't work
		if (keyUp && !keyLeft && !keyRight && !keyDown)
		{
			map.DudeJump(moveToX + 1, moveToZ);

		}
		if (keyDown && !keyUp && !keyLeft && !keyRight)
		{
			map.DudeJump(moveToX - 1, moveToZ);

		}
		if (keyLeft && !keyRight && !keyUp && !keyDown)
		{
			map.DudeJump(moveToX, moveToZ - 1);

		}
		if (keyRight && !keyLeft && !keyUp && !keyDown)
		{
			map.DudeJump(moveToX, moveToZ + 1);

		}
	}
}
