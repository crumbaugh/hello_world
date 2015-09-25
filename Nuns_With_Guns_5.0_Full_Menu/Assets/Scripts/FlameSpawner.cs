using UnityEngine;
using System.Collections;

public class FlameSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		minX = Floor.GetComponent<floorTiles>().minX;
		maxX = Floor.GetComponent<floorTiles>().maxX;
		minY = Floor.GetComponent<floorTiles>().minY;
		maxY = Floor.GetComponent<floorTiles>().maxY;
		xpos = Random.Range(minX, maxX);
		ypos = Random.Range(miny, maxY);
		Instantiate(
	}
}
