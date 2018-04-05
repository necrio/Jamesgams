using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeMoveTo : MonoBehaviour {
	public int tileX;
	public int tileZ;
	public TileMap map;

	private void OnMouseUp()
	{
		Debug.Log("clicked");
		map.DudeJump(tileX, tileZ);

	}
}
